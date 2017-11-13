<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AnnotationLayout.aspx.vb" Inherits="AnnotationLayout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:WebChartControl ID="WebChartControl1" runat="server" Height="400px"
		Width="700px" ClientInstanceName="chart" CrosshairEnabled="False" CssClass="AlignCenter TopLargeMargin"
		ToolTipEnabled="False">
		<SeriesSerializable>
			<dx:Series SeriesID="0" Name="Mars Ambient Temperature" ArgumentScaleType="Numerical" LabelsVisibility="False">
				<Points>
					<dx:SeriesPoint Values="-28.2" ArgumentSerializable="2.466424"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-25.4" ArgumentSerializable="2.486035"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-23.4" ArgumentSerializable="2.505635"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-22.4" ArgumentSerializable="2.525235"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-21" ArgumentSerializable="2.544851"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-19.7" ArgumentSerializable="2.564458"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-15.9" ArgumentSerializable="2.584058"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-15.3" ArgumentSerializable="2.603669"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-15.3" ArgumentSerializable="2.623269"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-18.9" ArgumentSerializable="2.64288"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-21.1" ArgumentSerializable="2.66249"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-23.2" ArgumentSerializable="2.682092"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-26.9" ArgumentSerializable="2.701703"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-30.8" ArgumentSerializable="2.721314"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-43.8" ArgumentSerializable="2.760537"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-45.7" ArgumentSerializable="2.780148"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-49.1" ArgumentSerializable="2.79976"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-51.5" ArgumentSerializable="2.819371"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-55.5" ArgumentSerializable="2.838982"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-57.5" ArgumentSerializable="2.858594"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-61" ArgumentSerializable="2.878205"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-61.1" ArgumentSerializable="2.897816"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-64.5" ArgumentSerializable="2.917428"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-64.9" ArgumentSerializable="2.937039"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-67.8" ArgumentSerializable="2.976262"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-69.3" ArgumentSerializable="3.035084"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-70.4" ArgumentSerializable="3.074307"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-71.3" ArgumentSerializable="3.093918"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-71.9" ArgumentSerializable="3.11353"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-75" ArgumentSerializable="3.191964"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-76" ArgumentSerializable="3.211575" SeriesPointID="30"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-74.7" ArgumentSerializable="3.231186"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-71.6" ArgumentSerializable="3.250786"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-67.2" ArgumentSerializable="3.270398"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-63.7" ArgumentSerializable="3.289998"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-59.5" ArgumentSerializable="3.309609"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-53" ArgumentSerializable="3.329209"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-47.7" ArgumentSerializable="3.34882"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-44.3" ArgumentSerializable="3.368421"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-42" ArgumentSerializable="3.388032"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-36" ArgumentSerializable="3.407632"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-32.6" ArgumentSerializable="3.427243"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-29.8" ArgumentSerializable="3.446843"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-27" ArgumentSerializable="3.466274"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-22.3" ArgumentSerializable="3.505486"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-19.5" ArgumentSerializable="3.544708"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-17.1" ArgumentSerializable="3.56432"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-15.1" ArgumentSerializable="3.603531"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-14.8" ArgumentSerializable="3.623142"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-19.2" ArgumentSerializable="3.642742"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-19.5" ArgumentSerializable="3.662343"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-22.4" ArgumentSerializable="3.681954"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-26.1" ArgumentSerializable="3.701565"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-32.1" ArgumentSerializable="3.721177"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-39.2" ArgumentSerializable="3.740788"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-45.2" ArgumentSerializable="3.760399"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-46.6" ArgumentSerializable="3.78001"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-49.9" ArgumentSerializable="3.799622"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-55.2" ArgumentSerializable="3.819233"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-58.4" ArgumentSerializable="3.838844"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-60.1" ArgumentSerializable="3.858456"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-60.2" ArgumentSerializable="3.878068"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-60.8" ArgumentSerializable="3.897678"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-63.9" ArgumentSerializable="3.91729"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-65.1" ArgumentSerializable="3.936901"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-66.3" ArgumentSerializable="3.956512"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-68.7" ArgumentSerializable="3.976124"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-65.5" ArgumentSerializable="3.995735"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-66" ArgumentSerializable="4.015346"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-67.5" ArgumentSerializable="4.034958"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-67.4" ArgumentSerializable="4.054569"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-69.1" ArgumentSerializable="4.07418"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-71.2" ArgumentSerializable="4.093792"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-71.1" ArgumentSerializable="4.113403"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-72.6" ArgumentSerializable="4.133014"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-72.5" ArgumentSerializable="4.152626"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-73.9" ArgumentSerializable="4.172237"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-73.5" ArgumentSerializable="4.21146"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-74.8" ArgumentSerializable="4.231071"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-71.7" ArgumentSerializable="4.250684"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-64.6" ArgumentSerializable="4.270294"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-61.8" ArgumentSerializable="4.289895"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-52.9" ArgumentSerializable="4.309505"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-43.7" ArgumentSerializable="4.370569"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-39.3" ArgumentSerializable="4.387928"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-33.3" ArgumentSerializable="4.427139"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-32.6" ArgumentSerializable="4.446739"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-30.9" ArgumentSerializable="4.46617"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-23.6" ArgumentSerializable="4.52737"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-20.3" ArgumentSerializable="4.544582"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-16.1" ArgumentSerializable="4.564193"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-14.6" ArgumentSerializable="4.583793" SeriesPointID="91"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-15.7" ArgumentSerializable="4.603404"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-15.5" ArgumentSerializable="4.623004"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-15.7" ArgumentSerializable="4.642616"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-20.6" ArgumentSerializable="4.662216"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-21.5" ArgumentSerializable="4.681816"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-26.4" ArgumentSerializable="4.701427"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-31.7" ArgumentSerializable="4.721039"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-39.4" ArgumentSerializable="4.74065"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-45.1" ArgumentSerializable="4.760261"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-49" ArgumentSerializable="4.782272"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-50.2" ArgumentSerializable="4.799484"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-54.5" ArgumentSerializable="4.819095"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-57.9" ArgumentSerializable="4.838706"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-59.2" ArgumentSerializable="4.858318"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-63.4" ArgumentSerializable="4.877929"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-62.9" ArgumentSerializable="4.89754"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-60.9" ArgumentSerializable="4.917152"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-63.6" ArgumentSerializable="4.936763"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-63.2" ArgumentSerializable="4.95874"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-68.8" ArgumentSerializable="4.975986"></dx:SeriesPoint>
					<dx:SeriesPoint Values="-67.5" ArgumentSerializable="4.995586"></dx:SeriesPoint>
				</Points>
				<ViewSerializable>
					<dx:SplineSeriesView MarkerVisibility="False"></dx:SplineSeriesView>
				</ViewSerializable>
			</dx:Series>
		</SeriesSerializable>
		<Legend Visibility="False"></Legend>
		<BorderOptions Visibility="False"></BorderOptions>
		<Titles>
			<dx:ChartTitle Text="Mars Pathfinder Temperature Data"></dx:ChartTitle>
			<dx:ChartTitle Dock="Bottom" Alignment="Far" Text="From www-k12.atmos.washington.edu/k12" Font="Tahoma, 8pt" TextColor="Gray"></dx:ChartTitle>
		</Titles>
		<DiagramSerializable>
			<dx:XYDiagram>
				<AxisX Title-Text="Sol" Title-Visibility="True" VisibleInPanesSerializable="-1">
					<Strips>
						<dx:Strip Color="80, 120, 120, 120" ShowInLegend="False" Name="Night1">
							<MinLimit AxisValueSerializable="2.748"></MinLimit>
							<MaxLimit AxisValueSerializable="3.216"></MaxLimit>
							<FillStyle FillMode="Solid">
								<OptionsSerializable>
									<dx:SolidFillOptions></dx:SolidFillOptions>
								</OptionsSerializable>
							</FillStyle>
						</dx:Strip>
						<dx:Strip Color="80, 120, 120, 120" ShowInLegend="False" Name="Night2">
							<MinLimit AxisValueSerializable="3.748"></MinLimit>
							<MaxLimit AxisValueSerializable="4.216"></MaxLimit>
							<FillStyle FillMode="Solid">
								<OptionsSerializable>
									<dx:SolidFillOptions></dx:SolidFillOptions>
								</OptionsSerializable>
							</FillStyle>
						</dx:Strip>
						<dx:Strip Color="80, 120, 120, 120" ShowInLegend="False" Name="Night3">
							<MinLimit AxisValueSerializable="4.748"></MinLimit>
							<MaxLimit AxisValueSerializable="5.216"></MaxLimit>
							<FillStyle FillMode="Solid">
								<OptionsSerializable>
									<dx:SolidFillOptions></dx:SolidFillOptions>
								</OptionsSerializable>
							</FillStyle>
						</dx:Strip>
					</Strips>                     
				</AxisX>
				<AxisY Title-Text="Temperature, &#176;C" Title-Visibility="True" VisibleInPanesSerializable="-1">                     
				</AxisY>
				<DefaultPane EnableAxisXScrolling="False" EnableAxisYScrolling="False" EnableAxisXZooming="False" EnableAxisYZooming="False"></DefaultPane>
			</dx:XYDiagram>
		</DiagramSerializable>
		<AnnotationRepository>
			<dx:TextAnnotation Text="Minimum: -76" RuntimeMoving="True" RuntimeResizing="True" RuntimeRotation="True" Name="Minimum">
				<AnchorPointSerializable>
					<dx:SeriesPointAnchorPoint SeriesID="0" SeriesPointID="30"></dx:SeriesPointAnchorPoint>
				</AnchorPointSerializable>
				<ShapePositionSerializable>
					<dx:RelativePosition ConnectorLength="65" Angle="-248"></dx:RelativePosition>
				</ShapePositionSerializable>
			</dx:TextAnnotation>
			<dx:TextAnnotation Text="Maximum: -14.6" RuntimeMoving="True" RuntimeResizing="True" RuntimeRotation="True" Name="Maximum">
				<AnchorPointSerializable>
					<dx:SeriesPointAnchorPoint SeriesID="0" SeriesPointID="91"></dx:SeriesPointAnchorPoint>
				</AnchorPointSerializable>
				<ShapePositionSerializable>
					<dx:RelativePosition ConnectorLength="37.148312257092805" Angle="-320.98616184697175"></dx:RelativePosition>
				</ShapePositionSerializable>
			</dx:TextAnnotation>
			<dx:ImageAnnotation ConnectorStyle="None" RuntimeAnchoring="True" RuntimeMoving="True" RuntimeResizing="True" RuntimeRotation="True" Name="Mars">
				<Image ImageUrl="~/Content/Demo/Mars.png"></Image>
				<AnchorPointSerializable>
					<dx:ChartAnchorPoint X="110" Y="60"></dx:ChartAnchorPoint>
				</AnchorPointSerializable>
				<ShapePositionSerializable>
					<dx:RelativePosition ConnectorLength="0" Angle="0"></dx:RelativePosition>
				</ShapePositionSerializable>
			</dx:ImageAnnotation>
			<dx:TextAnnotation Text="Day" RuntimeAnchoring="True" RuntimeMoving="True" RuntimeResizing="True" RuntimeRotation="True" Name="Day">
				<AnchorPointSerializable>
					<dx:PaneAnchorPoint>
						<AxisXCoordinate AxisValueSerializable="2.5632"></AxisXCoordinate>
						<AxisYCoordinate AxisValueSerializable="-54.0941176470588"></AxisYCoordinate>
					</dx:PaneAnchorPoint>
				</AnchorPointSerializable>
				<ShapePositionSerializable>
					<dx:RelativePosition ConnectorLength="0" Angle="0"></dx:RelativePosition>
				</ShapePositionSerializable>
			</dx:TextAnnotation>
			<dx:TextAnnotation Text="Night" RuntimeAnchoring="True" RuntimeMoving="True" RuntimeResizing="True" RuntimeRotation="True" Name="Night">
				<AnchorPointSerializable>
					<dx:PaneAnchorPoint>
						<AxisXCoordinate AxisValueSerializable="2.984"></AxisXCoordinate>
						<AxisYCoordinate AxisValueSerializable="-35.0020761245675"></AxisYCoordinate>
					</dx:PaneAnchorPoint>
				</AnchorPointSerializable>
				<ShapePositionSerializable>
					<dx:RelativePosition ConnectorLength="0" Angle="0"></dx:RelativePosition>
				</ShapePositionSerializable>
			</dx:TextAnnotation>
		</AnnotationRepository>
	</dx:WebChartControl>
</asp:Content>