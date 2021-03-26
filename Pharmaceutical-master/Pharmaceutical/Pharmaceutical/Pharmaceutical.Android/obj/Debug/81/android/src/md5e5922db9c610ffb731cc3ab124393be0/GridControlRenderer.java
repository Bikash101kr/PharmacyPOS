package md5e5922db9c610ffb731cc3ab124393be0;


public class GridControlRenderer
	extends md51558244f76c53b6aeda52c8a337f2c37.VisualElementRenderer_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_detachViewFromParent:(I)V:GetDetachViewFromParent_IHandler\n" +
			"n_onDetachedFromWindow:()V:GetOnDetachedFromWindowHandler\n" +
			"n_onAttachedToWindow:()V:GetOnAttachedToWindowHandler\n" +
			"";
		mono.android.Runtime.register ("DevExpress.Mobile.DataGrid.Android.GridControlRenderer, DevExpress.Mobile.Grid.Android.v18.1", GridControlRenderer.class, __md_methods);
	}


	public GridControlRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == GridControlRenderer.class)
			mono.android.TypeManager.Activate ("DevExpress.Mobile.DataGrid.Android.GridControlRenderer, DevExpress.Mobile.Grid.Android.v18.1", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public GridControlRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == GridControlRenderer.class)
			mono.android.TypeManager.Activate ("DevExpress.Mobile.DataGrid.Android.GridControlRenderer, DevExpress.Mobile.Grid.Android.v18.1", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public GridControlRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == GridControlRenderer.class)
			mono.android.TypeManager.Activate ("DevExpress.Mobile.DataGrid.Android.GridControlRenderer, DevExpress.Mobile.Grid.Android.v18.1", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public void detachViewFromParent (int p0)
	{
		n_detachViewFromParent (p0);
	}

	private native void n_detachViewFromParent (int p0);


	public void onDetachedFromWindow ()
	{
		n_onDetachedFromWindow ();
	}

	private native void n_onDetachedFromWindow ();


	public void onAttachedToWindow ()
	{
		n_onAttachedToWindow ();
	}

	private native void n_onAttachedToWindow ();

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
