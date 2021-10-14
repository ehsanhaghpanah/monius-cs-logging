function uninstall_packages
{
	$list=@{
		"Core\Data\Logging"=@(
			"moniüs.Common",
			"moniüs.Base"
		);
		"Data\Core\Logging"=@(
			"moniüs.Common.Data",
			"moniüs.Common",
			"moniüs.Base"
		);
		"Test\Renegade"=@(
			"moniüs.Common",
			"moniüs.Base"
		);
		"WwW\Core\WCF\Core"=@(
			"moniüs.Common",
			"moniüs.Base"
		);
		"WwW\Edge\Corn"=@(
			"moniüs.Common",
			"moniüs.Base"
		);
		"WwW\Implementation\Compatability"=@(
			"moniüs.Common.WwW.Data.Compatability",
			"moniüs.Common.WwW.Data",
			"moniüs.Common",
			"moniüs.Base"
		);
		"WwW\Test\BackEnd"=@(
			"moniüs.Common",
			"moniüs.Base"
		);

	}

	foreach ($item in $list.GetEnumerator()) {
		foreach ($idol in $item.Value)
		{
			try
			{
				uninstall-package -id $idol -projectname $item.Name
			}
			catch
			{
				Write-Host "uninstall"
				Write-Host $idol -foregroundcolor red -backgroundcolor yellow
				Write-Host $item.Name -foregroundcolor red -backgroundcolor white
				#break
				exit
			}
		}
	}
}

function install_packages
{
	$list=@{
		"Core\Data\Logging"=@(
			"moniüs.Base",
			"moniüs.Common"
		);
		"Data\Core\Logging"=@(
			"moniüs.Base",
			"moniüs.Common",
			"moniüs.Common.Data"
		);
		"Test\Renegade"=@(
			"moniüs.Base",
			"moniüs.Common"
		);
		"WwW\Core\WCF\Core"=@(
			"moniüs.Base",
			"moniüs.Common"
		);
		"WwW\Edge\Corn"=@(
			"moniüs.Base",
			"moniüs.Common"
		);
		"WwW\Implementation\Compatability"=@(
			"moniüs.Base",
			"moniüs.Common",
			"moniüs.Common.WwW.Data",
			"moniüs.Common.WwW.Data.Compatability"
		);
		"WwW\Test\BackEnd"=@(
			"moniüs.Base",
			"moniüs.Common"
		);

	}

	$version = "0.3.2.0";
	foreach ($item in $list.GetEnumerator()) {
		foreach ($idol in $item.Value)
		{
			try
			{
				install-package -id $idol -Version $version -projectname $item.Name
			}
			catch
			{
				Write-Host "install"
				Write-Host $idol -foregroundcolor red -backgroundcolor yellow
				Write-Host $item.Name -foregroundcolor red -backgroundcolor white
				#break
				exit
			}
		}
	}
}

# main script
uninstall_packages
install_packages