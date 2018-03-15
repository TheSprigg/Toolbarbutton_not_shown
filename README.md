# Toolbarbutton_not_shown

Problem:
Toolbar button is not shown on Android when "SetSupportActionBar()" is set in MainActivity

Description:
"SetSupportActionBar()" has to be set to be able to intercept "OnOptionsItemSelected()". 
Unfortunately after adding this line of code the toolbar item is not shown at the started page. The toolbar item is shown after navigating to a different page and back

Steps
1. Start App
Expected: Toolbar item "Menu1" should be present
Actual: No toolbar item is present

2. Navigate to second page via button

3. Navigate back via toolbar this works and "OnOptionsItemSelected()" is triggered
Expected and Actual: Toolbar item "Menu1" is shown and working

When "SetSupportActionBar()" is not set "OnOptionsItemSelected()" in MainActivity is not triggered

Tested on Samsung Galaxy Tab S2 (Android 7.0)

On iOS/UWP this behaviour has not been tested yet.
