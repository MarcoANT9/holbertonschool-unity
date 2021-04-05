# 0x09. Unity - AR Business Card

## Task

#### Task 0. Let's see Paul Allen's card
In this project, you will create a business card for yourself with an AR-identifiable printed marker. You can use the following image or create your own. If you create your own, you must upload it in the form below.

<img src="https://holbertonintranet.s3.amazonaws.com/uploads/medias/2019/1/ffa666d97ab0c121ebb1.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIARDDGGGOUWMNL5ANN%2F20210405%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20210405T185936Z&X-Amz-Expires=86400&X-Amz-SignedHeaders=host&X-Amz-Signature=8e5688cbf3ceef4df10c628ef177abbde6137bad3e195ea654e3d994887d80cf" alt="HolbertonQRExample">

Create a static layout for the business card in a Unity scene called ARBusinessCard. We strongly suggest you sketch out your business card layout (as well as storyboarding its subsequent animation for task #2) before opening up Unity. Your layout must include:

* your name
* job title
* at least four links, in text or button form
    * email
    * website / github
    * twitter
    * linkedin
    * or any other link or social media you want to use to promote yourself

You can find logos / icons for your buttons [here](https://intranet.hbtn.io/rltoken/V3OJK6Hh7Ugd94slQqkANw).

Upload a screenshot of your business card layout, put the link in a text file named 0-layout, and submit the link to the form below.

## Task 1. Target acquired
Set up a target image database in Vuforia’s Target Manager and set up your AR marker such that your business card layout appears when your device’s camera detects the marker.

The layout should be anchored to the marker and the layout’s transform values should change depending on the marker’s angle, pose, and distance in relation to the device’s camera. If the marker is not visible, all elements of the business card should disappear.

## Task 2. Animated reality
Add animations to your layout. The design and feel of the experience is up to you but keep in mind the overall user experience (text should be legible, buttons should be large enough to press individually, etc.)

Be dynamic and play to the strengths of the AR medium — animation is key!

## Task 3. Social link up
Script the links to be interactive. When they are pressed on the device screen, they should open the associated link or app. The buttons should also give some kind of visual or audible feedback when pressed, such as the button changing color or a sound like a beep or click. Keep in mind [accessibility guidelines](https://intranet.hbtn.io/rltoken/hNgEW5XMsGvq2i-SF2DXKw) in your UI/UX decisions!

## Task 4. Building cards
Scenes in Build:

* ARBusinessCard

Create two builds of the business card scene in the Builds directory.

Build Folder Hierarchy:

* Builds
    * iOS
        * [Build files]
    * Android
        * ARBusinessCard.apk

Make sure to run your build and make sure it works! Test your build on all platforms if possible, but at the very least test on your own device.

Create a .zip of each build:

* 0x09-unity-ar_business_card-iOS.zip
* 0x09-unity-ar_business_card-Android.zip

Upload the two .zip files to Google Drive or Dropbox. Add the links to the files below.
