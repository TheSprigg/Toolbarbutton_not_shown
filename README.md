# Toolbarbutton_not_shown

Problem:
Toolbar button is not shown on Android when "SetSupportActionBar()" is set in MainActivity

Description:
"SetSupportActionBar()" has to be set to be able to intercept "OnOptionsItemSelected()". 
When not setting "SetSupportActionBar()" the function "OnOptionsItemSelected()" in MainActivity will not be triggered.

Unfortunately after adding this line of code the toolbar item is not shown at the first page after startup (MainPage). The toolbar item will appear after navigating to a different page and back to MainPage.

Steps:
1. Start App.  <br />
Expected: Toolbar item "About" should be present <br />
Actual: No toolbar item is present

2. Navigate to second page via button

3. Navigate back via toolbar. This works and "OnOptionsItemSelected()" is triggered. <br />
Expected and Actual: Toolbar item "About" is now shown on MainPage and is working. 


Tested on Samsung Galaxy Tab S2 (Android 7.0)

On iOS/UWP this behaviour has not been tested yet.
