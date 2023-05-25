# GriasdiWinFormApp
This is my conceptual idea of a MVVM based windows forms app: 

- a form does not consist of any custom code behind except automatically generated one by Visual Studio
- a form reference is stored in a custom view object that is defined in a ViewBase class
- the reference of the custom view object is stored in a custom view model object that is defined in a ViewModelBase class
- the startup project has been created at first place using a default windows forms project template within Visual Studio and modified afterwards as follows:
  1. Introducing a custom Application Context Class GriasdiAppContext that derives from ApplicationContext
  2. Replacing Application.Run(MainView()) with Application.Run(appContext) therefore removing the direct coupling to a form object
  3. Enrich forementioned ViewBase and ViewModelBase classes with corresponding event handlers that mimic the windows form closed and closing event concept in an custom but abstract manner
  4. Bundle up all measurements especially windows form initiated event handling within GriasdiAppContext of startup project GriasdiWinFormApp e.g. avoid quitting application if a user accidentally clicks on [x] - button of main application window

By the way: When it comes to employ a kind of "wrapper" or "decorator" pattern that encapsulates a native windows forms object in custom abstracted objects like view resp. view model it is kind a weired to mimic a corresponding e.Cancel = true setting on form closing because custom ViewBase resp. ViewModelBase had no similiar Cancel concept at the first place. Because of this custom GriasdiViewEventArgs and GriasdiViewModelEventArgs classes that consist of a Cancel method derived from GriasdiEventArgs have been introduced. When ever a windows form closed or closing event fires up a custom but abstract GriasdiViewEventArg object will be created and populated with the native Windows forms event arguments e.g. FormClosingEventArgs that derives from CancelEventArgs. The custom GriasdiEventArgs then bubbles upwards to their consuming and corrsponding event handlers. So, if a user clicks on No-button of the decision message box "Do you really want to close the application ?" a simple the Cancel() - method of ViewModelBase resp. the corresponding distinct implementation will be called: Cancel()-method of the custom view event args object and finally setting Cancel=true of the stored FormClosingEventArgs - object.   
