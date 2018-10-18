# DMS -Document Management System

# Technologies
C# ASP.NET core 2.1 (MVC ) , 3-tier Architechture, EF Code First

# Features
<ul>
	<li>Admin Creates Users & assign Roles</li>
	<li>User get notified by email for credentials</li>
	<li>User can creates own categories</li>
	<li>User can upload own documents</li>
	<li>User can Search & Downloads</li>
</ul>

# Screenshots
<img src="readme/1.png" alt="demo"/>
<img src="readme/2.png" alt="demo"/>
<img src="readme/4.png" alt="demo"/>
<img src="readme/5.png" alt="demo"/>

# installation
step 1: $ git clone https://github.com/nayeemazad/DMS.git <br>
step 2.1: go to directory DMS/DMS.WebUI/wwwroot <br>
step 2.2: look for the file named as "UNZIP_ME.zip" and unzip it at DMS/DMS.WebUI/wwwroot <br>
step 3.1: go to directory DMS/DMS.Service/ <br>
Step 3.2: find SendMail() function at UserService.cs <br>
step 3.3: Replace your e-Mail Address and email password for NetworkCredential <br>
