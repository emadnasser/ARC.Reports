using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace HybridApp.Views {
    public sealed class SwipeActionControl : ContentControl {
        Border mainContentPresenterBorder;
        Grid leftContentGrid;
        Grid rightContentGrid;
        Grid leftFiller;
        Grid rightFiller;
        public SwipeActionControl() {
            DefaultStyleKey = typeof(SwipeActionControl);
        }
        public double TranslationX {
            get { return ((TranslateTransform)mainContentPresenterBorder.RenderTransform).X; }
            set {
                ((TranslateTransform)mainContentPresenterBorder.RenderTransform).X = value;
                UpdateVisibility();
            }
        }
        public double LeftTranslationX {
            get { return ((TranslateTransform)leftContentGrid.RenderTransform).X; }
            set { ((TranslateTransform)leftContentGrid.RenderTransform).X = value; }
        }
        public double RightTranslationX {
            get { return ((TranslateTransform)rightContentGrid.RenderTransform).X; }
            set { ((TranslateTransform)rightContentGrid.RenderTransform).X = value; }
        }
        protected override void OnApplyTemplate() {
            base.OnApplyTemplate();
            mainContentPresenterBorder = (Border)GetTemplateChild("PART_MainContentPresenterBorder");
            leftContentGrid = (Grid)GetTemplateChild("PART_LeftContentGrid");
            rightContentGrid = (Grid)GetTemplateChild("PART_RightContentGrid");
            leftFiller = (Grid)GetTemplateChild("PART_LeftFiller");
            rightFiller = (Grid)GetTemplateChild("PART_RightFiller");

            mainContentPresenterBorder.ManipulationCompleted += MainContentPresenter_ManipulationCompleted;
            mainContentPresenterBorder.ManipulationDelta += MainContentPresenter_ManipulationDelta;
            mainContentPresenterBorder.ManipulationMode = ManipulationModes.System | ManipulationModes.TranslateX;
        }
        void MainContentPresenter_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e) {
            if(Math.Abs(e.Cumulative.Translation.X) < DragStartedDistance)
                return;
            double translationNextValue = TranslationX + e.Delta.Translation.X;
            if((LeftContent == null && translationNextValue > 0) || (RightContent == null && translationNextValue < 0))
                TranslationX = 0;
            else
                TranslationX = translationNextValue;
            e.Handled = true;
        }
        void MainContentPresenter_ManipulationCompleted(object sender, ManipulationCompletedRoutedEventArgs e) {
            ExecutCommand();
            TranslationX = 0;
        }
        void ExecutCommand() {
            if(TranslationX >= ExecutionOffset && LeftCommand != null && LeftCommand.CanExecute(LeftCommandParameter)) {
                LeftCommand.Execute(LeftCommandParameter);
            } else if(-TranslationX >= ExecutionOffset && RightCommand != null && RightCommand.CanExecute(RightCommandParameter)) {
                RightCommand.Execute(RightCommandParameter);
            }
        }
        void UpdateVisibility() {
            if(TranslationX > 0) {
                UpdateLeftSwipe();
            } else if(TranslationX < 0) {
                UpdateRightSwipe();
            } else {
                leftContentGrid.Visibility = Visibility.Collapsed;
                leftFiller.Visibility = Visibility.Collapsed;
                rightContentGrid.Visibility = Visibility.Collapsed;
                rightFiller.Visibility = Visibility.Collapsed;
            }
        }
        void UpdateLeftSwipe() {
            leftContentGrid.Visibility = Visibility.Visible;
            leftFiller.Visibility = Visibility.Visible;
            rightContentGrid.Visibility = Visibility.Collapsed;
            rightFiller.Visibility = Visibility.Collapsed;
            if(Math.Abs(TranslationX) < ExecutionOffset) {
                LeftTranslationX = -ExecutionOffset / 4 + TranslationX * 0.75;
                var newWidth = TranslationX - LeftTranslationX;
                leftContentGrid.Width = newWidth > 0 ? newWidth : 1;
            } else {
                LeftTranslationX = 0;
                leftContentGrid.Width = Math.Abs(TranslationX);
            }
            if(LeftTranslationX > 0)
                leftFiller.Width = LeftTranslationX;
            else
                leftFiller.Visibility = Visibility.Collapsed;
        }
        void UpdateRightSwipe() {
            rightContentGrid.Visibility = Visibility.Visible;
            rightFiller.Visibility = Visibility.Visible;
            leftContentGrid.Visibility = Visibility.Collapsed;
            leftFiller.Visibility = Visibility.Collapsed;
            if(Math.Abs(TranslationX) < ExecutionOffset) {
                RightTranslationX = -(ExecutionOffset / 4 + TranslationX * 0.75);
                var newWidth = -(TranslationX + RightTranslationX);
                rightContentGrid.Width = newWidth > 0 ? newWidth : 1;
            } else {
                RightTranslationX = 0;
                rightContentGrid.Width = Math.Abs(TranslationX);
            }
            if(RightTranslationX > 0)
                rightFiller.Width = RightTranslationX;
            else
                rightFiller.Visibility = Visibility.Collapsed;
        }
        public Brush LeftBackground {
            get { return (Brush)GetValue(LeftBackgroundProperty); }
            set { SetValue(LeftBackgroundProperty, value); }
        }
        public static readonly DependencyProperty LeftBackgroundProperty =
            DependencyProperty.Register("LeftBackground", typeof(Brush), typeof(SwipeActionControl), new PropertyMetadata(null));
        public Brush RightBackground {
            get { return (Brush)GetValue(RightBackgroundProperty); }
            set { SetValue(RightBackgroundProperty, value); }
        }
        public static readonly DependencyProperty RightBackgroundProperty =
            DependencyProperty.Register("RightBackground", typeof(Brush), typeof(SwipeActionControl), new PropertyMetadata(null));
        public object LeftContent {
            get { return (object)GetValue(LeftContentProperty); }
            set { SetValue(LeftContentProperty, value); }
        }
        public static readonly DependencyProperty LeftContentProperty =
            DependencyProperty.Register("LeftContent", typeof(object), typeof(SwipeActionControl), new PropertyMetadata(null));
        public object RightContent {
            get { return (object)GetValue(RightContentProperty); }
            set { SetValue(RightContentProperty, value); }
        }
        public static readonly DependencyProperty RightContentProperty =
            DependencyProperty.Register("RightContent", typeof(object), typeof(SwipeActionControl), new PropertyMetadata(null));
        public ICommand LeftCommand {
            get { return (ICommand)GetValue(LeftCommandProperty); }
            set { SetValue(LeftCommandProperty, value); }
        }
        public static readonly DependencyProperty LeftCommandProperty =
            DependencyProperty.Register("LeftCommand", typeof(ICommand), typeof(SwipeActionControl), new PropertyMetadata(null));
        public object LeftCommandParameter {
            get { return (object)GetValue(LeftCommandParameterProperty); }
            set { SetValue(LeftCommandParameterProperty, value); }
        }
        public static readonly DependencyProperty LeftCommandParameterProperty =
            DependencyProperty.Register("LeftCommandParameter", typeof(object), typeof(SwipeActionControl), new PropertyMetadata(null));
        public ICommand RightCommand {
            get { return (ICommand)GetValue(RightCommandProperty); }
            set { SetValue(RightCommandProperty, value); }
        }
        public static readonly DependencyProperty RightCommandProperty =
            DependencyProperty.Register("RightCommand", typeof(ICommand), typeof(SwipeActionControl), new PropertyMetadata(null));
        public object RightCommandParameter {
            get { return (object)GetValue(RightCommandParameterProperty); }
            set { SetValue(RightCommandParameterProperty, value); }
        }
        public static readonly DependencyProperty RightCommandParameterProperty =
            DependencyProperty.Register("RightCommandParameter", typeof(object), typeof(SwipeActionControl), new PropertyMetadata(null));
        public double ExecutionOffset {
            get { return (double)GetValue(ExecutionOffsetProperty); }
            set { SetValue(ExecutionOffsetProperty, value); }
        }
        public static readonly DependencyProperty ExecutionOffsetProperty =
            DependencyProperty.Register("ExecutionOffset", typeof(double), typeof(SwipeActionControl), new PropertyMetadata(150d));
        public double DragStartedDistance {
            get { return (double)GetValue(DragStartedDistanceProperty); }
            set { SetValue(DragStartedDistanceProperty, value); }
        }
        public static readonly DependencyProperty DragStartedDistanceProperty =
            DependencyProperty.Register("DragStartedDistance", typeof(double), typeof(SwipeActionControl), new PropertyMetadata(10d));
        public DataTemplate LeftContentTemplate {
            get { return (DataTemplate)GetValue(LeftContentTemplateProperty); }
            set { SetValue(LeftContentTemplateProperty, value); }
        }
        public static readonly DependencyProperty LeftContentTemplateProperty =
            DependencyProperty.Register("LeftContentTemplate", typeof(DataTemplate), typeof(SwipeActionControl), new PropertyMetadata(null));
        public DataTemplate RightContentTemplate {
            get { return (DataTemplate)GetValue(RightContentTemplateProperty); }
            set { SetValue(RightContentTemplateProperty, value); }
        }
        public static readonly DependencyProperty RightContentTemplateProperty =
            DependencyProperty.Register("RightContentTemplate", typeof(DataTemplate), typeof(SwipeActionControl), new PropertyMetadata(null));
    }
}
