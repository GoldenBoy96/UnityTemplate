DO NOT MODIFY TEMPLATE, COPY AND CHANGE NAMESPACE IF YOU WANT TO USE IT

I. Directory structure:
- All the game should be put in a Directory inside Asset, for example: ".../Asset/CompanyName/ProjectName/..."
- Left default Asset blank for easier package import/reset/remove

II. Namespace:
- All script must have namespace to avoid conflict with external packages
Ex: namespace CompanyName/ProjectName/Directory/...

III. Naming convention:
- Script must follor C# naming convention, for example:
	+ private field: Camel Case started with underscore - "_fieldName"
	+ class, property, method name: Pascal Case - "ClassName", "PropertyName", "MethodName()"
	...
- Constants name should be Capitalize Snake Case - "CONSTANT_NAME"
- File name should be Uncapitalize Snake Case - "file_name"

IV. Unity object ref
- Do not hard ref object with the same level. Call through a Singleton Manager or use Observer Notify instead.
- Child objects can be hard ref to their parent object.

V. Performance
- All image should be .png
- All image height and width should be POT(power of 2: 2, 4, 8, 16, 32, 64...)
- Object Pooling should be used instead of Instantiate and Destroy, each Prefab to reuse must have Reset script.
- Avoid Scene Load if the game isn't too big. Each Screen should be an Element inside a Canvas and be controlled by an UIManager. 
- Avoid using static objects. Static would be loaded when the App open and will never be release. Use Singleton instead.

VI. Teamwork
- Each module should be handled by only one member to avoid conflict
- Never modify other members' Scenes
- Only the highest dev should work on Final Big Scenes 

VII. Clean call
- Avoid call a method directly from a same-level-gameObject script. Call through a Manager instead.
- Parent should store its child Component (like a local Manager), each child member should interact with others though parent.

VIII. MVC and Data Driven method
- Each module code structure should be in MVC model. 
	+ All logic should be handle by Controller.
	+ Controller save Data by Model. Controller communicate with Server and View though Model's Data
	+ Never handle game logic by View. View should only visualize Data read from Model.
	+ Models should be designed carefully.
- Benefit:
	+ Can easy to change UI for a core game
	+ Easier to communicate with Server though json
	+ Can work with other Engine/System

IX. Prefab Based
- Each Module should provide a Prefab so that other member can use it easily.
- Nothing should exist in the Final Scene, only a Manager is needed to Instantiate the rest for better game flow control.

X. Require Package
- NuGetForUnity: to install nuget from Unity side to prevent reset
  https://github.com/GlitchEnzo/NuGetForUnity
- DOTween: to control Transform instead of pure code for smoother visualization
  https://dotween.demigiant.com/

