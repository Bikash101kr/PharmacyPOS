package md5e5922db9c610ffb731cc3ab124393be0;


public class ExtendedScrollViewRenderer
	extends md51558244f76c53b6aeda52c8a337f2c37.ScrollViewRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onScrollChanged:(IIII)V:GetOnScrollChanged_IIIIHandler\n" +
			"n_overScrollBy:(IIIIIIIIZ)Z:GetOverScrollBy_IIIIIIIIZHandler\n" +
			"n_onTouchEvent:(Landroid/view/MotionEvent;)Z:GetOnTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"";
		mono.android.Runtime.register ("DevExpress.Mobile.DataGrid.Android.ExtendedScrollViewRenderer, DevExpress.Mobile.Grid.Android.v18.1", ExtendedScrollViewRenderer.class, __md_methods);
	}


	public ExtendedScrollViewRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == ExtendedScrollViewRenderer.class)
			mono.android.TypeManager.Activate ("DevExpress.Mobile.DataGrid.Android.ExtendedScrollViewRenderer, DevExpress.Mobile.Grid.Android.v18.1", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public ExtendedScrollViewRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == ExtendedScrollViewRenderer.class)
			mono.android.TypeManager.Activate ("DevExpress.Mobile.DataGrid.Android.ExtendedScrollViewRenderer, DevExpress.Mobile.Grid.Android.v18.1", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public ExtendedScrollViewRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == ExtendedScrollViewRenderer.class)
			mono.android.TypeManager.Activate ("DevExpress.Mobile.DataGrid.Android.ExtendedScrollViewRenderer, DevExpress.Mobile.Grid.Android.v18.1", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public ExtendedScrollViewRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == ExtendedScrollViewRenderer.class)
			mono.android.TypeManager.Activate ("DevExpress.Mobile.DataGrid.Android.ExtendedScrollViewRenderer, DevExpress.Mobile.Grid.Android.v18.1", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public void onScrollChanged (int p0, int p1, int p2, int p3)
	{
		n_onScrollChanged (p0, p1, p2, p3);
	}

	private native void n_onScrollChanged (int p0, int p1, int p2, int p3);


	public boolean overScrollBy (int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, boolean p8)
	{
		return n_overScrollBy (p0, p1, p2, p3, p4, p5, p6, p7, p8);
	}

	private native boolean n_overScrollBy (int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, boolean p8);


	public boolean onTouchEvent (android.view.MotionEvent p0)
	{
		return n_onTouchEvent (p0);
	}

	private native boolean n_onTouchEvent (android.view.MotionEvent p0);

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
