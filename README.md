# MintPlayer.AspNetCore.ChangePassword
[![NuGet Version](https://img.shields.io/nuget/v/MintPlayer.AspNetCore.ChangePassword.svg?style=flat)](https://www.nuget.org/packages/MintPlayer.AspNetCore.ChangePassword)
[![NuGet](https://img.shields.io/nuget/dt/MintPlayer.AspNetCore.ChangePassword.svg?style=flat)](https://www.nuget.org/packages/MintPlayer.AspNetCore.ChangePassword)
[![Build Status](https://travis-ci.org/MintPlayer/MintPlayer.AspNetCore.ChangePassword.svg?branch=master)](https://travis-ci.org/MintPlayer/MintPlayer.AspNetCore.ChangePassword)
![.NET Core](https://github.com/MintPlayer/MintPlayer.AspNetCore.ChangePassword/workflows/.NET%20Core/badge.svg)
[![License](https://img.shields.io/badge/License-Apache%202.0-green.svg)](https://opensource.org/licenses/Apache-2.0)

Most webbrowsers/password managers provide a shortcut to point the user to the page where they can change the password for the specific website.
This project provides a middleware that lets you handle these requests.

## Installation
### NuGet package manager
Open the NuGet package manager and install `MintPlayer.AspNetCore.ChangePassword` in your project
### Package manager console
Install-Package MintPlayer.AspNetCore.ChangePassword

## Usage

Map the middleware on the MVC endpoints:

	app.UseEndpoints(endpoints =>
	{
		endpoints.MapChangePassword(() => Url.RouteUrl("account-profile", new { }));

		endpoints.MapControllerRoute(
			name: "default",
			pattern: "{controller}/{action=Index}/{id?}");
	});

You can also supply a Task, which will be awaited inside the middleware:

	app.UseEndpoints(endpoints =>
	{
		endpoints.MapChangePassword(() => spaRouteService.GenerateUrl("account-profile", new { }));

		endpoints.MapControllerRoute(
			name: "default",
			pattern: "{controller}/{action=Index}/{id?}");
	});
