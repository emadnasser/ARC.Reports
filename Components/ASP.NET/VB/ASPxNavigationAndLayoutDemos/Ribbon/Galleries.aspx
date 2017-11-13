<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Galleries.aspx.vb" Inherits="Ribbon_Galleries" %>
<asp:Content ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<link rel="stylesheet" type="text/css" href="Css/Galleries.css" />
	<style type="text/css">
		.container {
			vertical-align: top;
			border-right: 1px solid #c8ccd1;
			border-bottom: 1px solid #c8ccd1;
			padding: 50px;
			height: 40px;
			background: url(Images/editor.png) no-repeat;
		}
		.EditorWindow,
		.EditorWindow .dxpc-contentWrapper {
			border: none!important;
		}
	</style>
	<%--start highlighted block--%>
	<script type="text/javascript">
		function onWindowResize(s, e) {
			ribbon.AdjustControl();
		}
		function onCommandExecuted(s, e) {
			var text = e.item.name;
			if(e.parameter !== null)
				text += ": " + e.parameter;
			label.SetText(text);
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div id="PopupPlaceHolder" style="height: 400px; margin-top: 10px;"></div>
	<dx:ASPxPopupControl ID="ASPxPopupControl" runat="server" ClientInstanceName="pc" ShowShadow="false" CssClass="EditorWindow"
		AllowResize="true" AllowDragging="false" CloseAction="None" ShowSizeGrip="True" PopupAction="None"
		ShowFooter="True" ShowHeader="false" PopupElementID="PopupPlaceHolder"
		PopupAlignCorrection="Disabled" PopupAnimationType="None" ShowOnPageLoad="true"
		MaxWidth="900px" MinWidth="320px" Width="750px" MaxHeight="1" MinHeight="1" Height="1"
		FooterText="Resize the ribbon by the size grip to see the control responsive layout functionality" FooterStyle-HorizontalAlign="Right" FooterStyle-Wrap="True">
		<ContentStyle Paddings-Padding="0"></ContentStyle>
		<ClientSideEvents AfterResizing="onWindowResize" />
		<ContentCollection>
			<dx:PopupControlContentControl>
				<table id="editor" style="width: 100%;">
					<tr style="height: 1px">
						<td>
							<dx:ASPxRibbon ID="ASPxRibbon" runat="server" ClientInstanceName="ribbon" BackColor="White" Width="100%" ShowFileTab="false">
								<ClientSideEvents CommandExecuted="onCommandExecuted"/>
								<Tabs>
									<dx:RibbonTab Text="Home">
										<Groups>
											<dx:RibbonGroup Name="Clipboard" Text="Clipboard">
												<Image IconID="reports_report_32x32"></Image>
												<Items>
													<dx:RibbonDropDownButtonItem Name="Paste" Text="Paste" Size="Large">
														<Items>
															<dx:RibbonDropDownButtonItem Name="Paste" Text="Paste">
																<SmallImage IconID="actions_insert_16x16">
																</SmallImage>
															</dx:RibbonDropDownButtonItem>
															<dx:RibbonDropDownButtonItem Name="Paste special" Text="Paste special">
																<SmallImage IconID="actions_insert_16x16">
																</SmallImage>
															</dx:RibbonDropDownButtonItem>
														</Items>
														<LargeImage IconID="actions_insert_32x32">
														</LargeImage>
													</dx:RibbonDropDownButtonItem>
													<dx:RibbonButtonItem Name="Cut" Text="Cut">
														<SmallImage IconID="edit_cut_16x16">
														</SmallImage>
													</dx:RibbonButtonItem>
													<dx:RibbonButtonItem Name="Copy" Text="Copy">
														<SmallImage IconID="actions_merge_16x16">
														</SmallImage>
													</dx:RibbonButtonItem>
													<dx:RibbonButtonItem Name="Clear" Text="Clear">
														<SmallImage IconID="actions_clear_16x16">
														</SmallImage>
													</dx:RibbonButtonItem>
												</Items>
											</dx:RibbonGroup>
											<dx:RibbonGroup Text="Font" Name="Font">
												<Image IconID="alignment_contentautoarrange_32x32"></Image>
												<Items>
													<dx:RibbonGalleryBarItem ImageWidth="150" ImageHeight="32" ShowText="false" MaxColumnCount="1" Name="Font">
														<PropertiesDropDownGallery RowCount="6" />
														<Groups>
															<dx:RibbonGalleryGroup Text="All Fonts">
																<Items>
																	<dx:RibbonGalleryItem Text="Arial" Value="Arial" Image-SpriteProperties-CssClass="fontArial"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Text="ArialBold" Value="ArialBold" Image-SpriteProperties-CssClass="fontArialBold"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Text="Comic Sans MS" Value="Comic Sans MS" Image-SpriteProperties-CssClass="fontComicSansMs"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Text="Courier New" Value="Courier New" Image-SpriteProperties-CssClass="fontCourierNew"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Text="Georgia" Value="Georgia" Image-SpriteProperties-CssClass="fontGeorgia"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Text="Lucida Sans" Value="Lucida Sans" Image-SpriteProperties-CssClass="fontLucidaSans"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Text="Times New Roman" Value="Times New Roman" Image-SpriteProperties-CssClass="fontTimesNewRoman"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Text="Verdana" Value="Verdana" Image-SpriteProperties-CssClass="fontVerdana"></dx:RibbonGalleryItem>
																</Items>
															</dx:RibbonGalleryGroup>
														</Groups>
													</dx:RibbonGalleryBarItem>
													<dx:RibbonToggleButtonItem Name="Bold">
														<SmallImage IconID="format_bold_16x16">
														</SmallImage>
													</dx:RibbonToggleButtonItem>
													<dx:RibbonToggleButtonItem Name="Italic">
														<SmallImage IconID="format_italic_16x16">
														</SmallImage>
													</dx:RibbonToggleButtonItem>
													<dx:RibbonGalleryDropDownItem Size="Small" Name="Underline">
														<PropertiesDropDownGallery ShowText="false" RowCount="6" ShowGroupText="false" ImageHeight="25" ImageWidth="150" />
														<SmallImage IconID="format_underline_16x16"></SmallImage>
														<Groups>
															<dx:RibbonGalleryGroup>
																<Items>
																	<dx:RibbonGalleryItem Value="Underline" ToolTip="Underline" Image-SpriteProperties-CssClass="underlineSolid"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Double underline" ToolTip="Double underline" Image-SpriteProperties-CssClass="underlineDouble"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Thick underline" ToolTip="Thick underline" Image-SpriteProperties-CssClass="underlineBold"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Dotted underline" ToolTip="Dotted underline" Image-SpriteProperties-CssClass="underlineDotted"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Dashed underline" ToolTip="Dashed underline" Image-SpriteProperties-CssClass="underlineWideDotted"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Dot-dash underline" ToolTip="Dot-dash underline" Image-SpriteProperties-CssClass="underlineDashDot"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Dot-dot-dash underline" ToolTip="Dot-dot-dash underline" Image-SpriteProperties-CssClass="underlineDashDoubleDot"></dx:RibbonGalleryItem>
																</Items>
															</dx:RibbonGalleryGroup>
														</Groups>
													</dx:RibbonGalleryDropDownItem>
												</Items>
											</dx:RibbonGroup>
											<dx:RibbonGroup Text="Paragraph">
												<Image IconID="format_showhidden_32x32"></Image>
												<Items>
													<dx:RibbonGalleryDropDownItem Name="Bullets" Size="Small">
														<PropertiesDropDownGallery ColumnCount="4" RowCount="2" ImageHeight="32" ImageWidth="32" ShowText="false"/>
														<SmallImage IconID="format_listbullets_16x16">
														</SmallImage>
														<Groups>
															<dx:RibbonGalleryGroup Text="Bullet Library">
																<Items>
																	<dx:RibbonGalleryItem Value="Black dot" ToolTip="Black dot" Image-SpriteProperties-CssClass="bulletBlackDot"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Square" ToolTip="Square" Image-SpriteProperties-CssClass="bulletSquare"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="White dot" ToolTip="White dot" Image-SpriteProperties-CssClass="bulletWhiteDot"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Arrow" ToolTip="Arrow" Image-SpriteProperties-CssClass="bulletArrow"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="White diamond" ToolTip="White diamond" Image-SpriteProperties-CssClass="bulletWhiteLozenge"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Black diamond" ToolTip="Black diamond" Image-SpriteProperties-CssClass="bulletBlackLozenge"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Check" ToolTip="Check" Image-SpriteProperties-CssClass="bulletCheck"></dx:RibbonGalleryItem>
																</Items>
															</dx:RibbonGalleryGroup>
														</Groups>
													</dx:RibbonGalleryDropDownItem>
													<dx:RibbonButtonItem Name="Numbering">
														<SmallImage IconID="format_listnumbers_16x16">
														</SmallImage>
													</dx:RibbonButtonItem>
													<dx:RibbonButtonItem Name="Multilevel List">
														<SmallImage IconID="format_listmultilevel_16x16">
														</SmallImage>
													</dx:RibbonButtonItem>
													<dx:RibbonButtonItem Name="Decrease Indent">
														<SmallImage IconID="format_indentdecrease_16x16">
														</SmallImage>
													</dx:RibbonButtonItem>

												</Items>
											</dx:RibbonGroup>
											<dx:RibbonGroup Text="Styles">
												<Image IconID="format_changefontstyle_32x32"></Image>
												<Items>
													<dx:RibbonGalleryBarItem ImageHeight="32" ImageWidth="64" MaxColumnCount="10" MaxTextWidth="67" Name="Style">
														<PropertiesDropDownGallery ShowGroupText="false" RowCount="6"/>
														<Groups>
															<dx:RibbonGalleryGroup>
																<Items>
																	<dx:RibbonGalleryItem Value="¶ Normal" Image-SpriteProperties-CssClass="styleNormal" Text="¶ Normal" ToolTip="¶ Normal"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="¶ No Spacing" Image-SpriteProperties-CssClass="styleNoSpacing" Text="¶ No Spacing" ToolTip="¶ No Spacing"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Heading 1" Image-SpriteProperties-CssClass="styleHeading1" Text="Heading 1" ToolTip="Heading 1"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Heading 2" Image-SpriteProperties-CssClass="styleHeading2" Text="Heading 2" ToolTip="Heading 2"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Title" Image-SpriteProperties-CssClass="styleTitle" Text="Title" ToolTip="Title"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Subtitle" Image-SpriteProperties-CssClass="styleSubtitle" Text="Subtitle" ToolTip="Subtitle"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Emphasis" Image-SpriteProperties-CssClass="styleEmphasis" Text="Emphasis" ToolTip="Emphasis"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Intense Emphasis" Image-SpriteProperties-CssClass="styleIntenseEmphasis" Text="Intense Emphasis" ToolTip="Intense Emphasis"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Strong" Image-SpriteProperties-CssClass="styleStrong" Text="Strong" ToolTip="Strong"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Quote" Image-SpriteProperties-CssClass="styleQuote" Text="Quote" ToolTip="Quote"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Intense Quote" Image-SpriteProperties-CssClass="styleIntenseQuote" Text="Intense Quote" ToolTip="Intense Quote"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Subtle Reference" Image-SpriteProperties-CssClass="styleSubtleReference" Text="Subtle Reference" ToolTip="Subtle Reference"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Intense Reference" Image-SpriteProperties-CssClass="styleIntenseReference" Text="Intense Reference" ToolTip="Intense Reference"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Book Title" Image-SpriteProperties-CssClass="styleBookTitle" Text="Book Title" ToolTip="Book Title"></dx:RibbonGalleryItem>
																</Items>
															</dx:RibbonGalleryGroup>
														</Groups>
													</dx:RibbonGalleryBarItem>
												</Items>
											</dx:RibbonGroup>
										</Groups>
									</dx:RibbonTab>
									<dx:RibbonTab Text="Insert">
										<Groups>
											 <dx:RibbonGroup Name="Illustrations" Text="Illustrations">
												 <Image IconID="content_image_32x32"></Image>
												<Items>
													<dx:RibbonButtonItem Name="Picture" Size="Large" Text="Picture">
														<LargeImage IconID="content_image_32x32">
														</LargeImage>
													</dx:RibbonButtonItem>
													<dx:RibbonGalleryBarItem ShowText="false" MaxColumnCount="6" RowCount="2" AllowSelectItem="false" Name="Shapes" ImageHeight="16" ImageWidth="16">
														<PropertiesDropDownGallery RowCount="6"/>
														<Groups>
															<dx:RibbonGalleryGroup Text="Basic">
																<Items>
																	<dx:RibbonGalleryItem Value="Rectangle" ToolTip="Rectangle" Image-SpriteProperties-CssClass="shapesRectangle"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Rounded Rectangle" ToolTip="Rounded Rectangle" Image-SpriteProperties-CssClass="shapesRoundedRectangle"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Ellipse" ToolTip="Ellipse" Image-SpriteProperties-CssClass="shapesEllipse"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Diamond" ToolTip="Diamond" Image-SpriteProperties-CssClass="shapesDiamond"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Trapezoid" ToolTip="Trapezoid" Image-SpriteProperties-CssClass="shapesTrapezoid"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Parallelogram" ToolTip="Parallelogram" Image-SpriteProperties-CssClass="shapesParallelogram"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Triangle" ToolTip="Triangle" Image-SpriteProperties-CssClass="shapesTriangle"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Right Triangle" ToolTip="Right Triangle" Image-SpriteProperties-CssClass="shapesRightTriangle"></dx:RibbonGalleryItem>
																</Items>
															</dx:RibbonGalleryGroup>
															<dx:RibbonGalleryGroup Text="Polygons and stars">
																<Items>
																	<dx:RibbonGalleryItem Value="Pentagon" ToolTip="Pentagon" Image-SpriteProperties-CssClass="shapesPentagon"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Hexagon" ToolTip="Hexagon" Image-SpriteProperties-CssClass="shapesHexagon"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Three-point Star" ToolTip="Three-point Star" Image-SpriteProperties-CssClass="shapesThreePointStar"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Four-point Star" ToolTip="Four-point Star" Image-SpriteProperties-CssClass="shapesFourPointStar"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Five-point Star" ToolTip="Five-point Star" Image-SpriteProperties-CssClass="shapesFivePointStar"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Six-point Star" ToolTip="Six-point Star" Image-SpriteProperties-CssClass="shapesSixPointStar"></dx:RibbonGalleryItem>
																</Items>
															</dx:RibbonGalleryGroup>
															<dx:RibbonGalleryGroup Text="Arrows">
																<Items>
																	<dx:RibbonGalleryItem Value="Arrow" ToolTip="Arrow" Image-SpriteProperties-CssClass="shapesArrow"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Notched Arrow" ToolTip="Notched Arrow" Image-SpriteProperties-CssClass="shapesNotchedArrow"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Pentagon Arrow" ToolTip="Pentagon Arrow" Image-SpriteProperties-CssClass="shapesPentagonArrow"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Chevron Arrow" ToolTip="Chevron Arrow" Image-SpriteProperties-CssClass="shapesChevronArrow"></dx:RibbonGalleryItem>
																</Items>
															</dx:RibbonGalleryGroup>
															<dx:RibbonGalleryGroup Text="Callouts">
																<Items>
																	<dx:RibbonGalleryItem Value="Rectangular Callout" ToolTip="Rectangular Callout" Image-SpriteProperties-CssClass="shapesRectangularCallout"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Rounded Rectangular Callout" ToolTip="Rounded Rectangular Callout" Image-SpriteProperties-CssClass="shapesRoundedRectangularCallout"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Elliptical Callout" ToolTip="Elliptical Callout" Image-SpriteProperties-CssClass="shapesEllipticalCallout"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Cloud Callout" ToolTip="Cloud Callout" Image-SpriteProperties-CssClass="shapesCloudCallout"></dx:RibbonGalleryItem>
																</Items>
															</dx:RibbonGalleryGroup>
															<dx:RibbonGalleryGroup Text="Symbols">
																<Items>
																	<dx:RibbonGalleryItem Value="Lightning Bolt" ToolTip="Lightning Bolt" Image-SpriteProperties-CssClass="shapesLightningBolt"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Check Mark" ToolTip="Check Mark" Image-SpriteProperties-CssClass="shapesCheckMark"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Multiply" ToolTip="Multiply" Image-SpriteProperties-CssClass="shapesMultiply"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Gear" ToolTip="Gear" Image-SpriteProperties-CssClass="shapesGear"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="Heart" ToolTip="Heart" Image-SpriteProperties-CssClass="shapesHeart"></dx:RibbonGalleryItem>
																</Items>
															</dx:RibbonGalleryGroup>
														</Groups>
													</dx:RibbonGalleryBarItem>
												</Items>
											</dx:RibbonGroup>
											<dx:RibbonGroup Text="Other">
												<Image IconID="content_watermark_32x32"></Image>
												<Items>
													<dx:RibbonGalleryDropDownItem Text="Watermark" Size="Large" Name="Watermark">
														<LargeImage IconID="content_watermark_32x32"></LargeImage>
														<PropertiesDropDownGallery ColumnCount="3" RowCount="3" ImageHeight="150" ImageWidth="120"/>
														<Groups>
															<dx:RibbonGalleryGroup Text="Confidential">
																<Items>
																	<dx:RibbonGalleryItem Value="CONFIDENTIAL1" Text="CONFIDENTIAL1" Image-SpriteProperties-CssClass="watermarkConfidential1"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="CONFIDENTIAL2" Text="CONFIDENTIAL2" Image-SpriteProperties-CssClass="watermarkConfidential2"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="DO NOT COPY 1" Text="DO NOT COPY 1" Image-SpriteProperties-CssClass="watermarkDontcopy1"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="DO NOT COPY 2" Text="DO NOT COPY 2" Image-SpriteProperties-CssClass="watermarkDontcopy2"></dx:RibbonGalleryItem>
																</Items>
															</dx:RibbonGalleryGroup>
															<dx:RibbonGalleryGroup Text="Disclaimers">
																<Items>
																	<dx:RibbonGalleryItem Value="DRAFT 1" Text="DRAFT 1" Image-SpriteProperties-CssClass="watermarkDraft1"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="DRAFT 2" Text="DRAFT 2" Image-SpriteProperties-CssClass="watermarkDraft2"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="SAMPLE 1" Text="SAMPLE 1" Image-SpriteProperties-CssClass="watermarkSample1"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="SAMPLE 2" Text="SAMPLE 2" Image-SpriteProperties-CssClass="watermarkSample2"></dx:RibbonGalleryItem>
																</Items>
															</dx:RibbonGalleryGroup>
															<dx:RibbonGalleryGroup Text="Urgent">
																<Items>
																	<dx:RibbonGalleryItem Value="ASAP 1" Text="ASAP 1" Image-SpriteProperties-CssClass="watermarkAsap1"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="ASAP 2" Text="ASAP 2" Image-SpriteProperties-CssClass="watermarkAsap2"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="URGENT 1" Text="URGENT 1" Image-SpriteProperties-CssClass="watermarkUrgent1"></dx:RibbonGalleryItem>
																	<dx:RibbonGalleryItem Value="URGENT 2" Text="URGENT 2" Image-SpriteProperties-CssClass="watermarkUrgent2"></dx:RibbonGalleryItem>
																</Items>
															</dx:RibbonGalleryGroup>
														</Groups>
													</dx:RibbonGalleryDropDownItem>
												</Items>
											</dx:RibbonGroup>
										</Groups>
									</dx:RibbonTab>
								</Tabs>
							</dx:ASPxRibbon>
						</td>
					</tr>
					 <tr>
						<td class="container" id="container">
							<dx:ASPxLabel runat="server" ID="ASPxLabel1" ClientInstanceName="label"></dx:ASPxLabel>
						</td>
					</tr>
				</table>
			</dx:PopupControlContentControl>
		</ContentCollection>
	</dx:ASPxPopupControl>
</asp:Content>