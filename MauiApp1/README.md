# DevExpressPopupBugReport


## BugReport


When loading a page if DxPopup is configured as follows:

```
<dxc:DXPopup x:Name="Popup" AllowShadow="False" AllowScrim="False" IsOpen="True" > 
   <StackLayout BackgroundColor="AliceBlue" Padding="5, 5" HorizontalOptions="FillAndExpand" HeightRequest="400">
          <Label Text="This is the DevExpress Popup component for .NET MAUI"/>     
          <Label Text="Tap outside the popup to hide it." FontAttributes="Bold"/>  
    </StackLayout>
</dxc:DXPopup>
```

**Actual Behavior**

The pop up does not display on page load.
If you inspect the  Popup in code behind and check the value of IsOpen it is false even though we have have hard coded it to true.

**Expected Behavior**

The pop up is displayed on page load.

[Link to reproduction](https://github.com/roughiain/DevExpressPopupBugReport)
