# AsyncFormsRepro

This is a repro project for an issue with WinForms in combination with ShowAsync().

Issue:

1. **Showing async MDI children**: MDI child forms cannot be shown asynchronously. 

3. **ShowAsync() does not set an owner but behaves like it would**: In the demo app, if you leave all checkboxes unset, you'll get a floating form that can also be covered by the main form.
If you check the Async checkbox only, the form will not get a parent and no owner. And still it behaves like it would have an owner.
That is: While the main form is not blocked and can be used, it cannot cover the form.

4. **Calling Show()/ShowAsync() twice**: While it makes no sense to do this, we found out that the behavior differs when calling Show() multiple times (no error) vs. calling ShowAsync() multiple times, which leads to exceptions.
Why is that and can this be changed to behave the same? I think the behavior of Show() is better here is it might just be setting Visible to true, which can be done multiple times as well.

