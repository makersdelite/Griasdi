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
