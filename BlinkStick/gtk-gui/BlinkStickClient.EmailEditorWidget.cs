
// This file has been generated by the GUI designer. Do not modify.
namespace BlinkStickClient
{
	public partial class EmailEditorWidget
	{
		private global::Gtk.VBox vbox4;
		
		private global::Gtk.Frame frame4;
		
		private global::Gtk.Alignment GtkAlignment;
		
		private global::Gtk.Table table1;
		
		private global::Gtk.Entry entryPassword;
		
		private global::Gtk.Entry entryServer;
		
		private global::Gtk.Entry entryUsername;
		
		private global::Gtk.HBox hbox3;
		
		private global::Gtk.SpinButton spinbuttonPort;
		
		private global::Gtk.CheckButton checkbuttonUseSSL;
		
		private global::Gtk.HBox hbox4;
		
		private global::Gtk.Label labelPortInfo;
		
		private global::Gtk.Label labelPassword;
		
		private global::Gtk.Label labelPort;
		
		private global::Gtk.Label labelServer;
		
		private global::Gtk.Label labelUsername;
		
		private global::Gtk.Label GtkLabel1;
		
		private global::Gtk.Frame frame1;
		
		private global::Gtk.Alignment GtkAlignment3;
		
		private global::Gtk.HBox hbox2;
		
		private global::Gtk.Label labelCheck;
		
		private global::Gtk.SpinButton spinbuttonCheckPeriod;
		
		private global::Gtk.Label labelMinutes;
		
		private global::Gtk.Label GtkLabel3;
		
		private global::Gtk.Frame frame5;
		
		private global::Gtk.Alignment GtkAlignment1;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Label labelCurrentValue;
		
		private global::Gtk.Button buttonRefresh;
		
		private global::Gtk.Label GtkLabel2;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget BlinkStickClient.EmailEditorWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "BlinkStickClient.EmailEditorWidget";
			// Container child BlinkStickClient.EmailEditorWidget.Gtk.Container+ContainerChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.frame4 = new global::Gtk.Frame ();
			this.frame4.Name = "frame4";
			this.frame4.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame4.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(5)), ((uint)(2)), false);
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			this.table1.BorderWidth = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.entryPassword = new global::Gtk.Entry ();
			this.entryPassword.CanFocus = true;
			this.entryPassword.Name = "entryPassword";
			this.entryPassword.IsEditable = true;
			this.entryPassword.Visibility = false;
			this.entryPassword.InvisibleChar = '●';
			this.table1.Add (this.entryPassword);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryPassword]));
			w1.TopAttach = ((uint)(1));
			w1.BottomAttach = ((uint)(2));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryServer = new global::Gtk.Entry ();
			this.entryServer.CanFocus = true;
			this.entryServer.Name = "entryServer";
			this.entryServer.IsEditable = true;
			this.entryServer.InvisibleChar = '●';
			this.table1.Add (this.entryServer);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryServer]));
			w2.TopAttach = ((uint)(2));
			w2.BottomAttach = ((uint)(3));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryUsername = new global::Gtk.Entry ();
			this.entryUsername.CanFocus = true;
			this.entryUsername.Name = "entryUsername";
			this.entryUsername.IsEditable = true;
			this.entryUsername.InvisibleChar = '●';
			this.table1.Add (this.entryUsername);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryUsername]));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.spinbuttonPort = new global::Gtk.SpinButton (0D, 65535D, 1D);
			this.spinbuttonPort.CanFocus = true;
			this.spinbuttonPort.Name = "spinbuttonPort";
			this.spinbuttonPort.Adjustment.PageIncrement = 10D;
			this.spinbuttonPort.ClimbRate = 1D;
			this.spinbuttonPort.Numeric = true;
			this.hbox3.Add (this.spinbuttonPort);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.spinbuttonPort]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.checkbuttonUseSSL = new global::Gtk.CheckButton ();
			this.checkbuttonUseSSL.CanFocus = true;
			this.checkbuttonUseSSL.Name = "checkbuttonUseSSL";
			this.checkbuttonUseSSL.Label = global::Mono.Unix.Catalog.GetString ("Use SSL");
			this.checkbuttonUseSSL.DrawIndicator = true;
			this.checkbuttonUseSSL.UseUnderline = true;
			this.hbox3.Add (this.checkbuttonUseSSL);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.checkbuttonUseSSL]));
			w5.Position = 1;
			this.table1.Add (this.hbox3);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox3]));
			w6.TopAttach = ((uint)(3));
			w6.BottomAttach = ((uint)(4));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.labelPortInfo = new global::Gtk.Label ();
			this.labelPortInfo.Name = "labelPortInfo";
			this.labelPortInfo.Xpad = 4;
			this.labelPortInfo.Xalign = 0F;
			this.labelPortInfo.LabelProp = global::Mono.Unix.Catalog.GetString ("<i>Default: ???</i>");
			this.labelPortInfo.UseMarkup = true;
			this.hbox4.Add (this.labelPortInfo);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.labelPortInfo]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			this.table1.Add (this.hbox4);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox4]));
			w8.TopAttach = ((uint)(4));
			w8.BottomAttach = ((uint)(5));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelPassword = new global::Gtk.Label ();
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Xalign = 1F;
			this.labelPassword.LabelProp = global::Mono.Unix.Catalog.GetString ("Password:");
			this.table1.Add (this.labelPassword);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelPassword]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelPort = new global::Gtk.Label ();
			this.labelPort.Name = "labelPort";
			this.labelPort.Xalign = 1F;
			this.labelPort.LabelProp = global::Mono.Unix.Catalog.GetString ("Port:");
			this.table1.Add (this.labelPort);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelPort]));
			w10.TopAttach = ((uint)(3));
			w10.BottomAttach = ((uint)(4));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelServer = new global::Gtk.Label ();
			this.labelServer.Name = "labelServer";
			this.labelServer.Xalign = 1F;
			this.labelServer.LabelProp = global::Mono.Unix.Catalog.GetString ("Server:");
			this.table1.Add (this.labelServer);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelServer]));
			w11.TopAttach = ((uint)(2));
			w11.BottomAttach = ((uint)(3));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelUsername = new global::Gtk.Label ();
			this.labelUsername.Name = "labelUsername";
			this.labelUsername.Xalign = 1F;
			this.labelUsername.LabelProp = global::Mono.Unix.Catalog.GetString ("Username:");
			this.table1.Add (this.labelUsername);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelUsername]));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment.Add (this.table1);
			this.frame4.Add (this.GtkAlignment);
			this.GtkLabel1 = new global::Gtk.Label ();
			this.GtkLabel1.Name = "GtkLabel1";
			this.GtkLabel1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Configure IMAP account settings</b>");
			this.GtkLabel1.UseMarkup = true;
			this.frame4.LabelWidget = this.GtkLabel1;
			this.vbox4.Add (this.frame4);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.frame4]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment3 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment3.Name = "GtkAlignment3";
			this.GtkAlignment3.LeftPadding = ((uint)(12));
			// Container child GtkAlignment3.Gtk.Container+ContainerChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			this.hbox2.BorderWidth = ((uint)(6));
			// Container child hbox2.Gtk.Box+BoxChild
			this.labelCheck = new global::Gtk.Label ();
			this.labelCheck.Name = "labelCheck";
			this.labelCheck.Xalign = 0F;
			this.labelCheck.LabelProp = global::Mono.Unix.Catalog.GetString ("Check every");
			this.hbox2.Add (this.labelCheck);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.labelCheck]));
			w16.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.spinbuttonCheckPeriod = new global::Gtk.SpinButton (1D, 120D, 1D);
			this.spinbuttonCheckPeriod.CanFocus = true;
			this.spinbuttonCheckPeriod.Name = "spinbuttonCheckPeriod";
			this.spinbuttonCheckPeriod.Adjustment.PageIncrement = 10D;
			this.spinbuttonCheckPeriod.ClimbRate = 1D;
			this.spinbuttonCheckPeriod.Numeric = true;
			this.spinbuttonCheckPeriod.Value = 1D;
			this.hbox2.Add (this.spinbuttonCheckPeriod);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.spinbuttonCheckPeriod]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.labelMinutes = new global::Gtk.Label ();
			this.labelMinutes.Name = "labelMinutes";
			this.labelMinutes.Xalign = 0F;
			this.labelMinutes.LabelProp = global::Mono.Unix.Catalog.GetString ("min");
			this.hbox2.Add (this.labelMinutes);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.labelMinutes]));
			w18.Position = 2;
			w18.Expand = false;
			w18.Fill = false;
			this.GtkAlignment3.Add (this.hbox2);
			this.frame1.Add (this.GtkAlignment3);
			this.GtkLabel3 = new global::Gtk.Label ();
			this.GtkLabel3.Name = "GtkLabel3";
			this.GtkLabel3.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Update frequency</b>");
			this.GtkLabel3.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel3;
			this.vbox4.Add (this.frame1);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.frame1]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.frame5 = new global::Gtk.Frame ();
			this.frame5.Name = "frame5";
			this.frame5.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame5.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			this.hbox1.BorderWidth = ((uint)(6));
			// Container child hbox1.Gtk.Box+BoxChild
			this.labelCurrentValue = new global::Gtk.Label ();
			this.labelCurrentValue.Name = "labelCurrentValue";
			this.labelCurrentValue.Xalign = 0F;
			this.labelCurrentValue.LabelProp = global::Mono.Unix.Catalog.GetString ("Value: (click refresh)");
			this.labelCurrentValue.UseMarkup = true;
			this.labelCurrentValue.Wrap = true;
			this.hbox1.Add (this.labelCurrentValue);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.labelCurrentValue]));
			w22.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonRefresh = new global::Gtk.Button ();
			this.buttonRefresh.CanFocus = true;
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.UseUnderline = true;
			global::Gtk.Image w23 = new global::Gtk.Image ();
			w23.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-refresh", global::Gtk.IconSize.Menu);
			this.buttonRefresh.Image = w23;
			this.hbox1.Add (this.buttonRefresh);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonRefresh]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			this.GtkAlignment1.Add (this.hbox1);
			this.frame5.Add (this.GtkAlignment1);
			this.GtkLabel2 = new global::Gtk.Label ();
			this.GtkLabel2.Name = "GtkLabel2";
			this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Current Value</b>");
			this.GtkLabel2.UseMarkup = true;
			this.frame5.LabelWidget = this.GtkLabel2;
			this.vbox4.Add (this.frame5);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.frame5]));
			w27.Position = 2;
			w27.Expand = false;
			w27.Fill = false;
			this.Add (this.vbox4);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.checkbuttonUseSSL.Toggled += new global::System.EventHandler (this.OnCheckbuttonUseSSLToggled);
			this.buttonRefresh.Clicked += new global::System.EventHandler (this.OnButtonRefreshClicked);
		}
	}
}
