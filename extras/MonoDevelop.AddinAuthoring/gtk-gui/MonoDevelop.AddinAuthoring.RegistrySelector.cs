
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.AddinAuthoring
{
	public partial class RegistrySelector
	{
		private global::Gtk.Button buttonBrowse;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label label;

		private global::Gtk.VSeparator vseparator1;

		private global::Gtk.Image image131;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.AddinAuthoring.RegistrySelector
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.AddinAuthoring.RegistrySelector";
			// Container child MonoDevelop.AddinAuthoring.RegistrySelector.Gtk.Container+ContainerChild
			this.buttonBrowse = new global::Gtk.Button ();
			this.buttonBrowse.CanFocus = true;
			this.buttonBrowse.Name = "buttonBrowse";
			// Container child buttonBrowse.Gtk.Container+ContainerChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label = new global::Gtk.Label ();
			this.label.Name = "label";
			this.label.Xalign = 0f;
			this.label.Ellipsize = ((global::Pango.EllipsizeMode)(3));
			this.hbox2.Add (this.label);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label]));
			w1.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vseparator1 = new global::Gtk.VSeparator ();
			this.vseparator1.Name = "vseparator1";
			this.hbox2.Add (this.vseparator1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vseparator1]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.image131 = new global::Gtk.Image ();
			this.image131.Name = "image131";
			this.image131.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-open", global::Gtk.IconSize.Menu);
			this.hbox2.Add (this.image131);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.image131]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.buttonBrowse.Add (this.hbox2);
			this.buttonBrowse.Label = null;
			this.Add (this.buttonBrowse);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.buttonBrowse.Clicked += new global::System.EventHandler (this.OnButtonBrowseClicked);
		}
	}
}