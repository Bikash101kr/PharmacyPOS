package md5e5922db9c610ffb731cc3ab124393be0;


public class TextEditorRenderer
	extends md51558244f76c53b6aeda52c8a337f2c37.EditorRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DevExpress.Mobile.DataGrid.Android.TextEditorRenderer, DevExpress.Mobile.Grid.Android.v18.1", TextEditorRenderer.class, __md_methods);
	}


	public TextEditorRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == TextEditorRenderer.class)
			mono.android.TypeManager.Activate ("DevExpress.Mobile.DataGrid.Android.TextEditorRenderer, DevExpress.Mobile.Grid.Android.v18.1", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public TextEditorRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == TextEditorRenderer.class)
			mono.android.TypeManager.Activate ("DevExpress.Mobile.DataGrid.Android.TextEditorRenderer, DevExpress.Mobile.Grid.Android.v18.1", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public TextEditorRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == TextEditorRenderer.class)
			mono.android.TypeManager.Activate ("DevExpress.Mobile.DataGrid.Android.TextEditorRenderer, DevExpress.Mobile.Grid.Android.v18.1", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
