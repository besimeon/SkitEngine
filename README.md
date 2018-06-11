# SkitEngine

This project was created for the purposes of creating a skit by saving the timestamps and names of animation parameters throughout multiple playthroughs of a given scene.  This allows easier animation coordination of multiple objects in a given scene.  

This project is in a primitive state.  If demand increases, I will flesh-out the interface and add checks to avoid potential scenarios noted throughout this readme.

* NOTE: This project was tested on Unity 2017.3.1f1.  I can't vouch for stability using earlier versions. 

* A sample skit is provided in the project located in: * ``` Scenes\SampleSkit ``` 

# Installation

1. Copy the contents of the Assets directory into a location of your choice. 
2. Start Unity, click 'Open', navigate to the location where the Assets directory is located, click 'Open'.

# Creating Skits

## On objects you want to record animation parameters for:
1. Add the following script components: 
	```TimeStampRecorder.cs SetAnimParameter.cs TimeStampReader.cs ```
2. Once you create an animation for said object, Unity should automatically add the Animator component.

## Configuring the UI

* NOTE: The provided scene titled "Sample Skit" contains a configured UI panel for reference.  

### In your UI, configure the following buttons, attach the following components, and specify the following functions+parameters on button actions FOR EACH object you wish to record parameter timestamps for:
1. Create/Open:
	a. TimeStampReader.cs
		-assign the desired object.
		-in the specified object, select the 'TimeStampRecorder' script.
		-and specify the CreateAndOpen() function.
2. Save
	a. TimeStampReader.cs
		-assign the desired object.
		-in the specified object, select the 'TimeStampRecorder' script.
		-and specify the SerializeAndSave() function.

3. For each animator parameter in the object in-question: 
	a. Create a button.
	b. Assign name = [Name of parameter]
	c. Assign the object in-question.
	d. Call the following functions, passing the following values: 
		-TimeStampRecorder.cs, SaveParamName, * value = [name of parameter] *
		-TimeStampRecorder.cs, SaveTimeStamp.
		-SetAnimParameter.cs, SetParamName, * value = [name of parameter] *
		-SetAnimParameter.cs, SetParamType, * value = [type of parameter] *
		-SetAnimParameter.cs, SetParameter.

## To record animation parameters:
1. Play the scene. 
2. Click the object on you wish to record animation parameters in the Hierarchy window.

* NOTE: as of v1.0, this is IMPORTANT, because the next step will generate an error if you don't click the object you wish to animate. *

3. Press the Create/Open Button to create or open an existing timestamp file. 
4. Press the * [parameter name] * buttons accordingly to animate the object as desired.

* NOTE: it is important that you save at least one parameter to populate the file created in step 3, otherwise an error will be generated. *

5. Press the Save button to save the timestamp file.
6. You can verify the parameters were saved at the timestamps where buttons were pressed by re-playing the scene.  The objects with the TimeStampReader.cs script attached will read the parameters and timestamps from the file and set them accordingly.

# ENJOY!

And that's it. Hopefully these instructions alongside the sample skit scene provide enough guidance for usage in your projects. I intend to create a video tutorial detailing the use case the SampleSkit scene was used for. A link to the tutorial will be provided here when completed.  

For feedback, contact me here in github or goto blakesimeon.com. 
