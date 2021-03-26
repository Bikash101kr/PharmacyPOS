package md5e5922db9c610ffb731cc3ab124393be0;


public class CustomSimpleOnScaleGestureListener
	extends android.view.ScaleGestureDetector.SimpleOnScaleGestureListener
	implements
		mono.android.IGCUserPeer,
		android.view.ScaleGestureDetector.OnScaleGestureListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onScaleBegin:(Landroid/view/ScaleGestureDetector;)Z:GetOnScaleBegin_Landroid_view_ScaleGestureDetector_Handler\n" +
			"n_onScale:(Landroid/view/ScaleGestureDetector;)Z:GetOnScale_Landroid_view_ScaleGestureDetector_Handler\n" +
			"n_onScaleEnd:(Landroid/view/ScaleGestureDetector;)V:GetOnScaleEnd_Landroid_view_ScaleGestureDetector_Handler\n" +
			"";
		mono.android.Runtime.register ("DevExpress.Mobile.DataGrid.Android.CustomSimpleOnScaleGestureListener, DevExpress.Mobile.Grid.Android.v18.1", CustomSimpleOnScaleGestureListener.class, __md_methods);
	}


	public CustomSimpleOnScaleGestureListener ()
	{
		super ();
		if (getClass () == CustomSimpleOnScaleGestureListener.class)
			mono.android.TypeManager.Activate ("DevExpress.Mobile.DataGrid.Android.CustomSimpleOnScaleGestureListener, DevExpress.Mobile.Grid.Android.v18.1", "", this, new java.lang.Object[] {  });
	}


	public boolean onScaleBegin (android.view.ScaleGestureDetector p0)
	{
		return n_onScaleBegin (p0);
	}

	private native boolean n_onScaleBegin (android.view.ScaleGestureDetector p0);


	public boolean onScale (android.view.ScaleGestureDetector p0)
	{
		return n_onScale (p0);
	}

	private native boolean n_onScale (android.view.ScaleGestureDetector p0);


	public void onScaleEnd (android.view.ScaleGestureDetector p0)
	{
		n_onScaleEnd (p0);
	}

	private native void n_onScaleEnd (android.view.ScaleGestureDetector p0);

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
