package md5e5922db9c610ffb731cc3ab124393be0;


public class DroidSegmentedButtonControl
	extends android.widget.RadioGroup
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFinishInflate:()V:GetOnFinishInflateHandler\n" +
			"";
		mono.android.Runtime.register ("DevExpress.Mobile.DataGrid.Android.DroidSegmentedButtonControl, DevExpress.Mobile.Grid.Android.v18.1", DroidSegmentedButtonControl.class, __md_methods);
	}


	public DroidSegmentedButtonControl (android.content.Context p0)
	{
		super (p0);
		if (getClass () == DroidSegmentedButtonControl.class)
			mono.android.TypeManager.Activate ("DevExpress.Mobile.DataGrid.Android.DroidSegmentedButtonControl, DevExpress.Mobile.Grid.Android.v18.1", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public DroidSegmentedButtonControl (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == DroidSegmentedButtonControl.class)
			mono.android.TypeManager.Activate ("DevExpress.Mobile.DataGrid.Android.DroidSegmentedButtonControl, DevExpress.Mobile.Grid.Android.v18.1", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public void onFinishInflate ()
	{
		n_onFinishInflate ();
	}

	private native void n_onFinishInflate ();

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
