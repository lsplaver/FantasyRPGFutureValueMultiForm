# FantasyRPGFutureValueMultiForm
By Lawrence Splaver

This is a Windows Forms app based off of the Future Value app from murach's C# 7th Edition.

This app calculates the compounded value of a fantasy game's bank account.

Version 1
* Based off of chapter 10
* Based off of FantasyRPGFutureValue v3
* Added second form to the app which displays the calculated values
* Using a richtextbox for displaying the values
* Switched Years and Months textboxes for comboboxes

Version 1.5
* Fixed: frmCalculator load event
* Fixed: txtRate missing tag property
* Changed int years and monthsPerYear to use SelectedIndex to prevent possible null warning
* Updated frmCalculator tab order
* Moved the List<> variable to be a global variable