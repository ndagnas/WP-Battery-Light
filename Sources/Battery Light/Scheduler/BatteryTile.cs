#region Using directives
//-------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
using Windows.UI;
using Windows.Data.Xml.Dom;
using Windows.UI.StartScreen;
using Windows.UI.Notifications;
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
using Windows.Phone.Devices.Power;
//-------------------------------------------------------------------------------------------------------------------------------
#endregion
//-------------------------------------------------------------------------------------------------------------------------------

//*******************************************************************************************************************************
// Début du bloc "Scheduler"
//*******************************************************************************************************************************
namespace Scheduler
	{

	//  ####    ###   #####  #####         #####  #  #      #####
	//  #   #  #   #    #      #             #    #  #      #    
	//  ####   #####    #      #    #####    #    #  #      ###  
	//  #   #  #   #    #      #             #    #  #      #    
	//  ####   #   #    #      #             #    #  #####  #####

	//***************************************************************************************************************************
	// Classe BatteryTile
	//***************************************************************************************************************************
	#region // Déclaration et Implémentation de l'Objet
	//---------------------------------------------------------------------------------------------------------------------------
	/// <summary>
	/// Définit la tuile.
	/// </summary>
	//---------------------------------------------------------------------------------------------------------------------------
	public static class BatteryTile
		{
		//***********************************************************************************************************************
		/// <summary>
		/// Obtiens les données de la tuile.
		/// </summary>
		//-----------------------------------------------------------------------------------------------------------------------
		public static IDictionary<string, string> GetTileData ()
			{
			//-------------------------------------------------------------------------------------------------------------------
			var BatteryInfos = Battery.GetDefault ();
			
			int ChargePercent           = BatteryInfos.RemainingChargePercent;
			var DischargeTime           = BatteryInfos.RemainingDischargeTime;

			string Title                = "";
			string WideContent1         = "";
			string WideContent2         = "";
			string SquareIcon           = "ms-appx:///Assets/SquareIconL6.png";
			string SquareImage          = "ms-appx:///Assets/SquareImageL6.png";
			string WideImage            = "ms-appx:///Assets/SquareImageL6.png";
			//-------------------------------------------------------------------------------------------------------------------

			//-------------------------------------------------------------------------------------------------------------------
			if ( DischargeTime.Minutes == 1 )
				{
				WideContent2 = string.Format ( "{0} {1}", DischargeTime.Minutes, AppResources.LabelMinute  );
				Title        = string.Format ( "{0} {1}", DischargeTime.Minutes, AppResources.LetterMinute );
				}
			else if ( DischargeTime.Minutes > 0 )
				{
				WideContent2 = string.Format ( "{0} {1}", DischargeTime.Minutes, AppResources.LabelMinutes );
				Title        = string.Format ( "{0} {1}", DischargeTime.Minutes, AppResources.LetterMinute );
				}

			if ( DischargeTime.Hours == 1 )
				{
				WideContent2 = string.Format ( "{0} {1}", DischargeTime.Hours, AppResources.LabelHour  ) + 
				                                                  ( ( ( WideContent2.Length > 0 ) ? ", " : "" ) + WideContent2 );
				Title        = string.Format ( "{0} {1}", DischargeTime.Hours, AppResources.LetterHour ) + 
				                                                  ( ( ( Title       .Length > 0 ) ? " "  : "" ) + Title        );
				}
			else if ( DischargeTime.Hours > 0 )
				{
				WideContent2 = string.Format ( "{0} {1}", DischargeTime.Hours, AppResources.LabelHours ) + 
				                                                  ( ( ( WideContent2.Length > 0 ) ? ", " : "" ) + WideContent2 );
				Title        = string.Format ( "{0} {1}", DischargeTime.Hours, AppResources.LetterHour ) + 
				                                                  ( ( ( Title       .Length > 0 ) ? " "  : "" ) + Title        );
				}

			if ( DischargeTime.Days == 1 )
				{
				WideContent2 = string.Format ( "{0} {1}", DischargeTime.Days, AppResources.LabelDay  ) + 
				                                                  ( ( ( WideContent2.Length > 0 ) ? ", " : "" ) + WideContent2 );
				Title        = string.Format ( "{0} {1}", DischargeTime.Days, AppResources.LetterDay ) + 
				                                                  ( ( ( Title       .Length > 0 ) ? " "  : "" ) + Title        );
				}
			else if ( DischargeTime.Days > 0 )
				{
				WideContent2 = string.Format ( "{0} {1}", DischargeTime.Days, AppResources.LabelDays ) + 
				                                                  ( ( ( WideContent2.Length > 0 ) ? ", " : "" ) + WideContent2 );
				Title        = string.Format ( "{0} {1}", DischargeTime.Days, AppResources.LetterDay ) + 
				                                                  ( ( ( Title       .Length > 0 ) ? " "  : "" ) + Title        );
				}
			//-------------------------------------------------------------------------------------------------------------------
			
			//-------------------------------------------------------------------------------------------------------------------
			if ( DischargeTime.Ticks == Int64.MaxValue )
				{
				//---------------------------------------------------------------------------------------------------------------
				if ( ChargePercent == 100 )
					{
					//-----------------------------------------------------------------------------------------------------------
					Title        = AppResources.ChargedFirstLine ;
					WideContent1 = AppResources.ChargedSecondLine;
					//-----------------------------------------------------------------------------------------------------------
					}
				//---------------------------------------------------------------------------------------------------------------
				else
					{
					//-----------------------------------------------------------------------------------------------------------
					Title        = AppResources.ExternalFirstLine ;
					WideContent1 = AppResources.ExternalSecondLine;
					WideContent2 = ""                             ;
					//-----------------------------------------------------------------------------------------------------------
					}
				//---------------------------------------------------------------------------------------------------------------
				}
			//-------------------------------------------------------------------------------------------------------------------
			else { WideContent1 = AppResources.BattRemaining; }
			//-------------------------------------------------------------------------------------------------------------------

			//-------------------------------------------------------------------------------------------------------------------
			if ( ChargePercent >= 100 )
				{
				}
			else if ( ChargePercent > 80 )
				{
				SquareIcon  = "ms-appx:///Assets/SquareIconL5.png";
				SquareImage = "ms-appx:///Assets/SquareImageL5.png";
				WideImage   = "ms-appx:///Assets/SquareIconL5.png";
				}
			else if ( ChargePercent > 60 )
				{
				SquareIcon  = "ms-appx:///Assets/SquareIconL4.png";
				SquareImage = "ms-appx:///Assets/SquareImageL4.png";
				WideImage   = "ms-appx:///Assets/SquareIconL4.png";
				}
			else if ( ChargePercent > 40 )
				{
				SquareIcon  = "ms-appx:///Assets/SquareIconL3.png";
				SquareImage = "ms-appx:///Assets/SquareImageL3.png";
				WideImage   = "ms-appx:///Assets/SquareIconL3.png";
				}
			else if ( ChargePercent > 20 )
				{
				SquareIcon  = "ms-appx:///Assets/SquareIconL2.png";
				SquareImage = "ms-appx:///Assets/SquareImageL2.png";
				WideImage   = "ms-appx:///Assets/SquareIconL2.png";
				}
			else
				{
				SquareIcon  = "ms-appx:///Assets/SquareIconL1.png";
				SquareImage = "ms-appx:///Assets/SquareImageL1.png";
				WideImage   = "ms-appx:///Assets/SquareIconL1.png";
				}
			//-------------------------------------------------------------------------------------------------------------------

			//-------------------------------------------------------------------------------------------------------------------
			Dictionary<string, string> Result = new Dictionary<string, string> ();

			Result["Badge"         ] = ChargePercent.ToString ();
			Result["Title"         ] = Title;
			Result["WideContent1"  ] = WideContent1;
			Result["WideContent2"  ] = WideContent2;
			Result["SquareIconUri" ] = SquareIcon;
			Result["SquareImageUri"] = SquareImage;
			Result["WideImageUri"  ] = WideImage;

			return Result;
			//-------------------------------------------------------------------------------------------------------------------
			}
		//***********************************************************************************************************************

		//***********************************************************************************************************************
		/// <summary>
		/// Crée une tuile secondaire.
		/// </summary>
		//-----------------------------------------------------------------------------------------------------------------------
		public static async void Pin ()
			{
			//-------------------------------------------------------------------------------------------------------------------
			if ( ! SecondaryTile.Exists ( "SecondaryTile.Logo" ) )
				{
				//---------------------------------------------------------------------------------------------------------------
				var LockScreenBadgeLogo = new Uri ( "ms-appx:///Assets/LockscreenIcon.png"  );
				var Square150x150Logo   = new Uri ( "ms-appx:///Assets/SquareImageTile.png" );
				var Square71x71Logo     = new Uri ( "ms-appx:///Assets/SquareIconTile.png"  );
				var Wide310x150Logo     = new Uri ( "ms-appx:///Assets/WideImageTile.png"   );
				//---------------------------------------------------------------------------------------------------------------

				//---------------------------------------------------------------------------------------------------------------
				var Tile = new Windows.UI.StartScreen.SecondaryTile ( "SecondaryTile.Logo" );

				Tile.Arguments                                  = "/Frm_Home.xaml";
				Tile.DisplayName                                = AppResources.ShortName;
				Tile.LockScreenBadgeLogo                        = LockScreenBadgeLogo;
				Tile.LockScreenDisplayBadgeAndTileText          = true;
				Tile.VisualElements.BackgroundColor             = Colors.Transparent;
				Tile.VisualElements.ForegroundText              = ForegroundText.Dark;
				Tile.VisualElements.ShowNameOnSquare150x150Logo = true;
				Tile.VisualElements.ShowNameOnWide310x150Logo   = true;
				Tile.VisualElements.Square150x150Logo           = Square150x150Logo;
				Tile.VisualElements.Square71x71Logo             = Square71x71Logo;
				Tile.VisualElements.Wide310x150Logo             = Wide310x150Logo;

				bool isPinned = await Tile.RequestCreateAsync ();

				if ( isPinned ) BatteryTile.Refresh ();
				//---------------------------------------------------------------------------------------------------------------
				}
			//-------------------------------------------------------------------------------------------------------------------
			}
		//***********************************************************************************************************************

		//***********************************************************************************************************************
		/// <summary>
		/// Rafraichis les données de la tuile.
		/// </summary>
		//-----------------------------------------------------------------------------------------------------------------------
		public static void Refresh ()
			{
			//-------------------------------------------------------------------------------------------------------------------
			try
				{
				//---------------------------------------------------------------------------------------------------------------
				var TileDatas = BatteryTile.GetTileData ();

				string TileContent = 
					"<tile>"                                                           +
					 "<visual version=\"3\">"                                          +
					  "<binding template=\"TileSquare71x71IconWithBadge\">"            +
					   "<image id=\"1\" src=\"" + TileDatas["SquareIconUri"] + "\"/>"  +
					  "</binding>"                                                     +
					  "<binding template=\"TileSquare150x150IconWithBadge\">"          +
					   "<image id=\"1\" src=\"" + TileDatas["SquareImageUri"] + "\"/>" +
					  "</binding>"                                                     +
					  "<binding template=\"TileWide310x150IconWithBadgeAndText\">"     +
					   "<image id=\"1\" src=\"" + TileDatas["WideImageUri"] + "\"/>"   +
					   "<text id=\"1\">" + TileDatas["WideContent1"] + "</text>"       +
					   "<text id=\"2\">" + TileDatas["WideContent2"] + "</text>"       +
					   "<text id=\"3\"></text>"                                        +
					  "</binding>"                                                     +
					 "</visual>"                                                       +
					"</tile>";
				//---------------------------------------------------------------------------------------------------------------

				//---------------------------------------------------------------------------------------------------------------
				var TileXml = new Windows.Data.Xml.Dom.XmlDocument ();

				TileXml.LoadXml ( TileContent );
				//---------------------------------------------------------------------------------------------------------------

				//---------------------------------------------------------------------------------------------------------------
				// Tuile Primaire
				//---------------------------------------------------------------------------------------------------------------
				var PrimaryTile = new TileNotification  ( TileXml );

				var PrimaryTileUpdater = TileUpdateManager.CreateTileUpdaterForApplication ();

				PrimaryTileUpdater.Update ( PrimaryTile );
				//---------------------------------------------------------------------------------------------------------------

				//---------------------------------------------------------------------------------------------------------------
				// Tuile Secondaire
				//---------------------------------------------------------------------------------------------------------------
				if ( SecondaryTile.Exists ( "SecondaryTile.Logo" ) )
					{
					//-----------------------------------------------------------------------------------------------------------
					var LockScreenBadgeLogo = new Uri ( "ms-appx:///Assets/LockscreenIcon.png"  );
					var Square150x150Logo   = new Uri ( "ms-appx:///Assets/SquareImageTile.png" );
					var Square71x71Logo     = new Uri ( "ms-appx:///Assets/SquareIconTile.png"  );
					var Wide310x150Logo     = new Uri ( "ms-appx:///Assets/WideImageTile.png"   );
					//-----------------------------------------------------------------------------------------------------------

					//-----------------------------------------------------------------------------------------------------------
					var Tile = new SecondaryTile ( "SecondaryTile.Logo" );

					Tile.Arguments                                  = "/Frm_Home.xaml";
					Tile.DisplayName                                = TileDatas["Title"];
					Tile.LockScreenBadgeLogo                        = LockScreenBadgeLogo;
					Tile.LockScreenDisplayBadgeAndTileText          = true;
					Tile.VisualElements.BackgroundColor             = Colors.Transparent;
					Tile.VisualElements.ForegroundText              = ForegroundText.Dark;
					Tile.VisualElements.ShowNameOnSquare150x150Logo = true;
					Tile.VisualElements.ShowNameOnWide310x150Logo   = true;
					Tile.VisualElements.Square150x150Logo           = Square150x150Logo;
					Tile.VisualElements.Square71x71Logo             = Square71x71Logo;
					Tile.VisualElements.Wide310x150Logo             = Wide310x150Logo;

					Tile.UpdateAsync ().AsTask ().Wait ();
					//-----------------------------------------------------------------------------------------------------------

					//-----------------------------------------------------------------------------------------------------------
					var SecondTile = new TileNotification  ( TileXml );

					var SecondaryTileUpdater = TileUpdateManager.CreateTileUpdaterForSecondaryTile ( "SecondaryTile.Logo" );

					SecondaryTileUpdater.Update ( SecondTile );
					//-----------------------------------------------------------------------------------------------------------
					}
				//---------------------------------------------------------------------------------------------------------------

				//---------------------------------------------------------------------------------------------------------------
				// Mise à jour du Badge
				//---------------------------------------------------------------------------------------------------------------
				if ( TileDatas["Badge"] == "100" )
					{
					//-----------------------------------------------------------------------------------------------------------
					BadgeUpdateManager.CreateBadgeUpdaterForApplication ().Clear ();

					if ( SecondaryTile.Exists ( "SecondaryTile.Logo" ) )
						BadgeUpdateManager.CreateBadgeUpdaterForSecondaryTile ( "SecondaryTile.Logo" ).Clear ();
					//-----------------------------------------------------------------------------------------------------------
					}
				//---------------------------------------------------------------------------------------------------------------
				else
					{
					//-----------------------------------------------------------------------------------------------------------
					XmlDocument BadgeXml = BadgeUpdateManager.GetTemplateContent ( BadgeTemplateType.BadgeNumber );

					XmlElement BadgeElement = (XmlElement)BadgeXml.SelectSingleNode ( "/badge" );

					BadgeElement.SetAttribute ( "value", TileDatas["Badge"] );

					BadgeUpdateManager.CreateBadgeUpdaterForApplication ().Update ( new BadgeNotification ( BadgeXml ) );

					if ( SecondaryTile.Exists ( "SecondaryTile.Logo" ) )
						BadgeUpdateManager.CreateBadgeUpdaterForSecondaryTile 
						    ( "SecondaryTile.Logo" ).Update ( new BadgeNotification ( BadgeXml ) );
					//-----------------------------------------------------------------------------------------------------------
					}
				//---------------------------------------------------------------------------------------------------------------
				}
			//-------------------------------------------------------------------------------------------------------------------
			catch {}
			//-------------------------------------------------------------------------------------------------------------------

			//-------------------------------------------------------------------------------------------------------------------
			}
		//***********************************************************************************************************************
		}
	//---------------------------------------------------------------------------------------------------------------------------
	#endregion
	//***************************************************************************************************************************

	} // Fin du namespace "Scheduler"
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// FIN DU FICHIER
//*******************************************************************************************************************************
