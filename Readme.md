Agora.io RTM SDK Cross-Platfrom samples
========================================

This repository contains samples of using Xamarin Agora.io RTM SDK Nuget packages

[Xamarin.Agora.Rtm.Android](https://www.nuget.org/packages/Xamarin.Agora.Rtm.Android/) [![NuGet Badge](https://buildstats.info/nuget/Xamarin.Agora.Rtm.Android)](https://www.nuget.org/packages/Xamarin.Agora.Rtm.Android/)

[Xamarin.Agora.Rtm.iOS](https://www.nuget.org/packages/Xamarin.Agora.Rtm.iOS/) [![NuGet Badge](https://buildstats.info/nuget/Xamarin.Agora.Rtm.iOS)](https://www.nuget.org/packages/Xamarin.Agora.Rtm.iOS/)

also contains a basic sample for Agora WebRTC


Running samples
-------------

1. Run app on any 2 devices

1. Enter your user name

1. Enter frend user name for Peer-to-Peer chat or enter Channel name.

1. Click Join button


Quick Start
-----------


1. Prepare Agora App ID, you can follow [Obtaining an App ID instructions](https://docs.agora.io/en/2.1.1/product/Video/Agora%20Basics/key_web#app-id-web) to get your App ID.

1. Replace the following empty string with the corresponding App ID:

* For Android app
    [Rtm/DT.Samples.Agora.Rtm.Droid/Resources/values/strings_config.xml](Rtm/DT.Samples.Agora.Rtm.Droid/Resources/values/strings_config.xml)
```xml
        <string translatable="false" name="agora_app_id">YOUR ID</string>
```
* For iOS app
    [Rtm/DT.Samples.Agora.Rtm.iOS/AppId.cs](Rtm/DT.Samples.Agora.Rtm.iOS/AppId.cs)
```c#
        public static string Id = "YOR ID";
```


What's Inside
-------------


In this repository you can find Rtm apps for Android and iOS


* **Xamarin iOS and Android** apps in one solution [Rtm/DT.Samples.Agora.Rtm.sln](Rtm/DT.Samples.Agora.Rtm.iOS.csproj)


Screenshots
-------------

Xamarin iOS

<img src="https://raw.githubusercontent.com/DreamTeamMobile/Agora-RTM-SDK-for-Xamarin/master/Screenshots/iOS/1.png" width="200" />
<img src="https://raw.githubusercontent.com/DreamTeamMobile/Agora-RTM-SDK-for-Xamarin/master/Screenshots/iOS/2.png" width="200" />
<img src="https://raw.githubusercontent.com/DreamTeamMobile/Agora-RTM-SDK-for-Xamarin/master/Screenshots/iOS/3.png" width="200" />
<img src="https://raw.githubusercontent.com/DreamTeamMobile/Agora-RTM-SDK-for-Xamarin/master/Screenshots/iOS/4.png" width="200" />
<img src="https://raw.githubusercontent.com/DreamTeamMobile/Agora-RTM-SDK-for-Xamarin/master/Screenshots/iOS/.png" width="200" />


Xamarin Android

<img src="https://raw.githubusercontent.com/DreamTeamMobile/Agora-RTM-SDK-for-Xamarin/master/Screenshots/Android/1.png" width="200" />
<img src="https://raw.githubusercontent.com/DreamTeamMobile/Agora-RTM-SDK-for-Xamarin/master/Screenshots/Android/2.png" width="200" />
<img src="https://raw.githubusercontent.com/DreamTeamMobile/Agora-RTM-SDK-for-Xamarin/master/Screenshots/Android/3.png" width="200" />
<img src="https://raw.githubusercontent.com/DreamTeamMobile/Agora-RTM-SDK-for-Xamarin/master/Screenshots/Android/4.png" width="200" />
<img src="https://raw.githubusercontent.com/DreamTeamMobile/Agora-RTM-SDK-for-Xamarin/master/Screenshots/Android/.png" width="200" />

