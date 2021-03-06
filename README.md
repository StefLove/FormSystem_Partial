# FormSystem_Partial
A system for managing forms. Developed in <b>C#.NET MVC</b>.<br />
<b>LINQ</b> is used to update (i.e. not <b>SQL</b>) the database which is a <b>MSSQL</b> one.<br />
Only this part of the code is free to view.<br />
If you want to view more code or buy the system, please contact me.<br />
Now I have improved the system by simplifying the code, this code here as You might see, needs more improvements.<br />
I am now converting this improved code to <b>C#.NET Core Razor Pages</b> which makes the whole system much simpler.<br />
UI in English.
<p />
<b>The code is a good example of the programming principles of</b><br />
<b>1)</b> <b>ViewModel:</b><br />
&nbsp;&nbsp;&nbsp; in https://github.com/StefLove/FormSystem_Partial/blob/master/EoS/Models/IdeaCarrier/Startup.cs<br />
&nbsp;&nbsp;&nbsp; row 166 and below.<br />
<b>2)</b> <b>virtual:</b><br />
&nbsp;&nbsp;&nbsp; see https://github.com/StefLove/FormSystem_Partial/blob/master/EoS/Controllers/StartupsController.cs<br />
&nbsp;&nbsp;&nbsp; rows 719 and 720 (virtual takes care of that modification in the database method SaveChanges).<br />
<b>3)</b> <b>Inheritence:</b><br />
&nbsp;&nbsp;&nbsp; Can also be used in ViewModels (and in Models of course !).<br />
&nbsp;&nbsp;&nbsp; In https://github.com/StefLove/FormSystem_Partial/blob/master/EoS/Models/IdeaCarrier/Startup.cs<br />
&nbsp;&nbsp;&nbsp; row 284 and below.<br />
&nbsp;&nbsp;&nbsp; (What do you do if you want more than 1 database table of the same model in ORM ? Simply use inheretence !)<br />
<b>4)</b> <b>No unnecessary updates of the database:</b><br />
&nbsp;&nbsp;&nbsp; in https://github.com/StefLove/FormSystem_Partial/blob/master/EoS/Controllers/StartupsController.cs<br />
&nbsp;&nbsp;&nbsp; Database method SaveChanges (rows 255,331,1066,1133,1175,1202,1239,1273) and<br />
&nbsp;&nbsp;&nbsp; EntityState method Modified (rows 327,1065,1132,1201,1238,1272).<br />
&nbsp;&nbsp;&nbsp; are only used when really necessary !<br />
<b>5)</b> <b>Code easier to read:</b><br />
&nbsp;&nbsp;&nbsp; in https://github.com/StefLove/FormSystem_Partial/blob/master/EoS/Controllers/StartupsController.cs<br />
&nbsp;&nbsp;&nbsp; using the pattern: var X = GetX(/*parameters*/). Rows 363,388,392.<br />
&nbsp;&nbsp;&nbsp; No use of Viewbags (or ViewData), except in Index (rows 28-114) (and ProjectDetails (rows 118-156),<br />
&nbsp;&nbsp;&nbsp; using ViewModels with SelectLists instead.<br />
&nbsp;&nbsp;&nbsp; Rows 202,204,267,269,358,367,369,378,394,396.<br />
<b>6)</b> <b>LINQ and ORM</b>:<br />
&nbsp;&nbsp;&nbsp; e.g. in https://github.com/StefLove/FormSystem_Partial/blob/master/EoS/Controllers/StartupsController.cs<br />
&nbsp;&nbsp;&nbsp; e.g. Rows 56,61,76,81,133,149.<br />
<b>7)</b> <b>Razor:</b><br />
&nbsp;&nbsp;&nbsp; e.g. in the cshtml files: https://github.com/StefLove/FormSystem_Partial/tree/master/EoS/Views
<p />
<b>Major differences between the old and the new code</b><br />
Have a look at https://github.com/StefLove/FormSystem_Partial/edit/master/EoS/Controllers/StartupsController_bad_old_code<br />
<b>1)</b> That horrible &#91;Bind(Include = "...")&#93; (which makes the code less readable and has that problem with overposting attacks)<br />
&nbsp;&nbsp;&nbsp; rows 162, 254 (really awful!).<br />
<b>2)</b> ViewBag after ViewBag (horrible too)<br />
&nbsp;&nbsp;&nbsp; 139-151, 197-207, 223-233, 294-303<br />
Compare with new code https://github.com/StefLove/FormSystem_Partial/blob/master/EoS/Controllers/StartupsController.cs<br />
<b>Most of the improvements:</b><br />
<b>1)</b> Instead of &#91;Bind(Include = "...")&#93; ViewModels are used:<br />
&nbsp;&nbsp;&nbsp; The code is much easier to read and follow now.<br />
&nbsp;&nbsp;&nbsp; Rows 216-272, 316-347, 349-403<br />
<b>2)</b> Viewbags are only used in Index (and in ProjectDetails, but that is easy to change):<br />
&nbsp;&nbsp;&nbsp; Rows 28-114, 118-156 (see also above under 5)).<br />
<b>3)</b> Names has been renamed and is now easier to understand because they follow a logic:<br />
&nbsp;&nbsp;&nbsp; Details (old code row 110) to ProjectDetails (row 118)<br />
&nbsp;&nbsp;&nbsp; Create (old code rows 137, 162)  to AddNewProject (rows 196, 216)<br />
&nbsp;&nbsp;&nbsp; Edit (old code rows 214, 254) is renamed to ProjectForm (rows 277, 316)<br />
&nbsp;&nbsp;&nbsp; Delete (old code row 362) to RemoveProject (row 1144)<br />
<b>4)</b> This new code is more effective and thus runs faster mainly due to the splitting of the ProjectForm into 5 parts:<br />
&nbsp;&nbsp;&nbsp; Have a look at the files containing the word ProjectForm in<br />
&nbsp;&nbsp;&nbsp; https://github.com/StefLove/FormSystem_Partial/tree/master/EoS/Views/Startups<br />
<b>5)</b> Unnessary code deleted:<br />
&nbsp;&nbsp;&nbsp; in https://github.com/StefLove/FormSystem_Partial/blob/master/EoS/Controllers/StartupsController_bad_old_code<br />
&nbsp;&nbsp;&nbsp; e.g. PopulateAssignedCheckBoxsData rows 300,585-647.<br />
<b>6)</b> The code is made easier to find (and thus to read):<br />
<!--&nbsp;&nbsp;&nbsp; e.g. using only Lists (very easy to use), in the old code even HashSets were used (without motivation).<br />-->
&nbsp;&nbsp;&nbsp; Rows 400-438 in the old code, replaced with better code: rows 818-856 in the new code. <br />
&nbsp;&nbsp;&nbsp; Rows 525-528,547-556 in the old code, replaced with better code: rows 425-443 in the new code.<p />
&nbsp;&nbsp;&nbsp; The result of these improvements of mine is that my code is faster and more dynamic than the old one.
<p />

Now you see that the developer who wrote the bad code was'nt that very skilled (more of a frontend developer),<br />
despite an education of 5 years in IT technology and programming !<br />
You just can't just be a plain developer, you must be an excellent developer who delivers code that works and looks nice !
<p />
An improved version of this system is published at http://eos.enabling.se<br />

Stefan<br />
Stockholm<br />
Sweden
