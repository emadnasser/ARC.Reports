Imports System

Namespace My.Resources


    ''' <summary>
    '''   A strongly-typed resource class, for looking up localized strings, etc.
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), _
    Global.Microsoft.VisualBasic.HideModuleNameAttribute()>
    Friend Module Resources

        Private resourceMan As Global.System.Resources.ResourceManager

        Private resourceCulture As Global.System.Globalization.CultureInfo

'        internal Resources()
'        {
'        }

        ''' <summary>
        '''   Returns the cached ResourceManager instance used by this class.
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As New Global.System.Resources.ResourceManager("Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property

        ''' <summary>
        '''   Overrides the current thread's CurrentUICulture property for all
        '''   resource lookups using this strongly typed resource class.
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set(ByVal value As System.Globalization.CultureInfo)
                resourceCulture = value
            End Set
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property Doctor() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Doctor", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        ''' </summary>
        Friend ReadOnly Property Employee() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("Employee", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Icon))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property glyph_backg_hover() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("glyph_backg_hover", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property glyph_backg_normal() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("glyph_backg_normal", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property glyph_backg_pressed() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("glyph_backg_pressed", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property glyph_mail_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("glyph_mail_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property glyph_message_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("glyph_message_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property glyph_phone_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("glyph_phone_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property glyph_video_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("glyph_video_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property HighPriority() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("HighPriority", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_A_24() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_A_24", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_A_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_A_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_about_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_about_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_about_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_about_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_add_column_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_add_column_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_arrow_bear_left_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_arrow_bear_left_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_arrow_bear_right_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_arrow_bear_right_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_arrow_forward_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_arrow_forward_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_arrow_left_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_arrow_left_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_arrow_right_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_arrow_right_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_arrow_turn_right_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_arrow_turn_right_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_arrow_uturn_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_arrow_uturn_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_B_24() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_B_24", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_B_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_B_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_brand_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_brand_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_buy_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_buy_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_buy_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_buy_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_card_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_card_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_card_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_card_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_carousel_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_carousel_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_carousel_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_carousel_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_change_view_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_change_view_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_change_view_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_change_view_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_close_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_close_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_close_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_close_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_cost_analysis_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_cost_analysis_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_cost_analysis_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_cost_analysis_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_cusomer_profile_report_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_cusomer_profile_report_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_customer_contact_directory_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_customer_contact_directory_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_customer_contact_directory_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_customer_contact_directory_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_customer_profile_report_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_customer_profile_report_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_customer_quick_employees_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_customer_quick_employees_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_customer_quick_locations_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_customer_quick_locations_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_customer_quick_sales_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_customer_quick_sales_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_customer_sale_detalis_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_customer_sale_detalis_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_customer_sale_detalis_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_customer_sale_detalis_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_customer_sales_summary_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_customer_sales_summary_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_customer_sales_summary_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_customer_sales_summary_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_data_panel_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_data_panel_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_data_panel_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_data_panel_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_delete_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_delete_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_delete_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_delete_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_docking_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_docking_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_driving_14() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_driving_14", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_driving_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_driving_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_driving_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_driving_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_edit_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_edit_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_edit_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_edit_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_email_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_email_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_employee_directory_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_employee_directory_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_employee_directory_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_employee_directory_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_employee_profile_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_employee_profile_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_employee_profile_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_employee_profile_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_employee_quick_award_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_employee_quick_award_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_employee_quick_excellence_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_employee_quick_excellence_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_employee_quick_probation_notice_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_employee_quick_probation_notice_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_employee_quick_thank_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_employee_quick_thank_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_employee_quick_welcome_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_employee_quick_welcome_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_employee_summary_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_employee_summary_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_employee_summary_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_employee_summary_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_employee_task_list_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_employee_task_list_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_employee_task_list_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_employee_task_list_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_expand_collapse_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_expand_collapse_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_expand_collapse_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_expand_collapse_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_export_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_export_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_export_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_export_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_export_40() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_export_40", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_filter_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_filter_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_filter_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_filter_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_fittopage_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_fittopage_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_folder_panel_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_folder_panel_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_folder_panel_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_folder_panel_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_getting_started_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_getting_started_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_getting_started_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_getting_started_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_Hide_product_img_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_Hide_product_img_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_Hide_product_img_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_Hide_product_img_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_home_phone_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_home_phone_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_list_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_list_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_list_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_list_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_mail_merge_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_mail_merge_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_mail_merge_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_mail_merge_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_mapit_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_mapit_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_mapit_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_mapit_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_meeting_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_meeting_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_meeting_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_meeting_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_mobile_phone_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_mobile_phone_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_nav_customers_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_nav_customers_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_nav_customers_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_nav_customers_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_nav_employees_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_nav_employees_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_nav_employees_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_nav_employees_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_nav_opportunities_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_nav_opportunities_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_nav_opportunities_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_nav_opportunities_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_nav_products_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_nav_products_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_nav_products_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_nav_products_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_nav_sales_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_nav_sales_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_nav_sales_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_nav_sales_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_navigate_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_navigate_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_navigate_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_navigate_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_new_customers_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_new_customers_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_new_customers_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_new_customers_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_new_doc_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_new_doc_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_new_doc_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_new_doc_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_new_employee_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_new_employee_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_new_employee_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_new_employee_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_new_group_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_new_group_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_new_group_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_new_group_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_new_item_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_new_item_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_new_item_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_new_item_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_new_opportunities_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_new_opportunities_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_new_opportunities_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_new_opportunities_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_new_products_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_new_products_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_new_products_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_new_products_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_new_sales_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_new_sales_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_new_sales_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_new_sales_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_normal_bottom_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_normal_bottom_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_open_doc_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_open_doc_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_open_doc_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_open_doc_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_opportunities_hight_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_opportunities_hight_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_opportunities_hight_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_opportunities_hight_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_opportunities_low_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_opportunities_low_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_opportunities_low_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_opportunities_low_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_opportunities_medium_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_opportunities_medium_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_opportunities_medium_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_opportunities_medium_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_opportunities_unlike_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_opportunities_unlike_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_opportunities_unlike_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_opportunities_unlike_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_page_next_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_page_next_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_page_prev_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_page_prev_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_pages_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_pages_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_panel_bottom_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_panel_bottom_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_panel_bottom_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_panel_bottom_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_panel_off_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_panel_off_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_panel_off_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_panel_off_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_panel_right_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_panel_right_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_panel_right_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_panel_right_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_prefix_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_prefix_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_print_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_print_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_print_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_print_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_print_42x40() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_print_42x40", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_print_due_date_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_print_due_date_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_print_due_date_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_print_due_date_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_print_exclude_evaluations_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_print_exclude_evaluations_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_print_include_evaluations_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_print_include_evaluations_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_print_preview_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_print_preview_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_print_preview_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_print_preview_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_print_quick_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_print_quick_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_print_quick_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_print_quick_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_print_sort_ascending_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_print_sort_ascending_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_print_sort_ascending_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_print_sort_ascending_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_print_sort_descinding_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_print_sort_descinding_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_print_sort_descinding_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_print_sort_descinding_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_print_start_date_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_print_start_date_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_print_start_date_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_print_start_date_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_product_order_detail_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_product_order_detail_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_product_order_detail_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_product_order_detail_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_product_quick_comparisons_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_product_quick_comparisons_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_product_quick_sales_report_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_product_quick_sales_report_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_product_quick_shippments_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_product_quick_shippments_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_product_quick_top_salesperson_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_product_quick_top_salesperson_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_product_sales_summary_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_product_sales_summary_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_product_sales_summary_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_product_sales_summary_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_product_specification_summary_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_product_specification_summary_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_product_specification_summary_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_product_specification_summary_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_reading_bottom_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_reading_bottom_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_redo_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_redo_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_redo_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_redo_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_reset_changes_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_reset_changes_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_reset_changes_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_reset_changes_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_revers_sort_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_revers_sort_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_revers_sort_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_revers_sort_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_revert_direction_14() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_revert_direction_14", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_sales_analysis_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_sales_analysis_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_sales_analysis_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_sales_analysis_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_sales_by_store_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_sales_by_store_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_sales_invoice_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_sales_invoice_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_sales_period_lifetime_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_sales_period_lifetime_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_sales_period_lifetime_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_sales_period_lifetime_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_sales_period_month_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_sales_period_month_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_sales_period_month_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_sales_period_month_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_sales_period_year_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_sales_period_year_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_sales_period_year_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_sales_period_year_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_sales_quick_invoice_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_sales_quick_invoice_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_sales_quick_report_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_sales_quick_report_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_sales_quick_summary_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_sales_quick_summary_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_sales_quick_thankyou_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_sales_quick_thankyou_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_sales_report_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_sales_report_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_save_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_save_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_save_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_save_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_save_as_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_save_as_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_save_as_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_save_as_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_save_close_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_save_close_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_save_close_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_save_close_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_show_product_img_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_show_product_img_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_show_product_img_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_show_product_img_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_skype_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_skype_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_Sort_by_Invoice_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_Sort_by_Invoice_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_Sort_by_Invoice_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_Sort_by_Invoice_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_Sort_by_OrderDate_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_Sort_by_OrderDate_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_Sort_by_OrderDate_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_Sort_by_OrderDate_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_support_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_support_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_support_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_support_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_task_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_task_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_task_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_task_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_undo_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_undo_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_undo_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_undo_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_view_reset_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_view_reset_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_view_reset_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_view_reset_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_view_setting_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_view_setting_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_view_setting_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_view_setting_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_walking_14() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_walking_14", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_walking_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_walking_16", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property icon_walking_32() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icon_walking_32", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property Jolt_Logo() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Jolt_Logo", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property LowPriority() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("LowPriority", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        ''' </summary>
        Friend ReadOnly Property MapIt() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("MapIt", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Icon))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property MediumPriority() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("MediumPriority", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property Miss() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Miss", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property Mr() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Mr", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property Mrs() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Mrs", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property Ms() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Ms", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property NormalPriority() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("NormalPriority", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property Overview_Buy() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Overview_Buy", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property Overview_FreeSupport() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Overview_FreeSupport", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property Overview_GettingStarted() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Overview_GettingStarted", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property Overview_Logo() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Overview_Logo", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property Search() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Search", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized resource of type System.Drawing.Bitmap.
        ''' </summary>
        Friend ReadOnly Property UISuperHero() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("UISuperHero", resourceCulture)
                Return (DirectCast(obj, System.Drawing.Bitmap))
            End Get
        End Property
    End Module
End Namespace
