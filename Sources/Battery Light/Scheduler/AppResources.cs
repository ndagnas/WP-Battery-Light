﻿//*******************************************************************************************************************************
// DEBUT DU FICHIER
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// Nom           : AppResources.cs
// Auteur        : Nicolas Dagnas
// Description   : Implémentation de l'objet AppResources
// Créé le       : 08/09/2014
// Modifié le    : 08/09/2014
//*******************************************************************************************************************************

//-------------------------------------------------------------------------------------------------------------------------------
#region Using directives
//-------------------------------------------------------------------------------------------------------------------------------
using System.Globalization;
//-------------------------------------------------------------------------------------------------------------------------------
#endregion
//-------------------------------------------------------------------------------------------------------------------------------

//*******************************************************************************************************************************
// Début du bloc "Scheduler"
//*******************************************************************************************************************************
namespace Scheduler
	{

	//   ###   ####   ####   ####   #####   ####   ###   #   #  ####    ###   #####   ####
	//  #   #  #   #  #   #  #   #  #      #      #   #  #   #  #   #  #   #  #      #    
	//  #####  ####   ####   ####   ###     ###   #   #  #   #  ####   #      ###     ### 
	//  #   #  #      #      #   #  #          #  #   #  #   #  #   #  #   #  #          #
	//  #   #  #      #      #   #  #####  ####    ###    ###   #   #   ###   #####  #### 

	//***************************************************************************************************************************
	// Classe AppResources
	//***************************************************************************************************************************
	#region // Déclaration et Implémentation de l'Objet
	//---------------------------------------------------------------------------------------------------------------------------
	/// <summary>
	/// Définit les ressources.
	/// </summary>
	//---------------------------------------------------------------------------------------------------------------------------
	internal static class AppResources
		{
		//***********************************************************************************************************************
		/// <summary>
		/// Constructeur statique de l'objet <b>AppResources</b>.
		/// </summary>
		//-----------------------------------------------------------------------------------------------------------------------
		static AppResources ()
			{
			//-------------------------------------------------------------------------------------------------------------------
			string CultureName = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName.ToUpper ();
			//-------------------------------------------------------------------------------------------------------------------

			//-------------------------------------------------------------------------------------------------------------------
			switch ( CultureName )
				{
				//---------------------------------------------------------------------------------------------------------------
				#region // DE
				//---------------------------------------------------------------------------------------------------------------
				case "DE" :
					{
					//-----------------------------------------------------------------------------------------------------------
					BattRemaining      = "Verbleibende Zeit";
					ExternalFirstLine  = "Unterstützung";
					ExternalSecondLine = "Aufladen des Akkus";
					LabelDay           = "tag";
					LabelDays          = "tage";
					LabelHour          = "stunde";
					LabelHours         = "stunden";
					LabelMinute        = "minute";
					LabelMinutes       = "minuten";
					LetterDay          = "t";
					LetterHour         = "s";
					LetterMinute       = "m";
					ShortName          = "Akkus";

					break;
					//-----------------------------------------------------------------------------------------------------------
					}
				//---------------------------------------------------------------------------------------------------------------
				#endregion
				//---------------------------------------------------------------------------------------------------------------
				#region // ES
				//---------------------------------------------------------------------------------------------------------------
				case "ES" :
					{
					//-----------------------------------------------------------------------------------------------------------
					BattRemaining      = "Tiempo restante";
					ExternalFirstLine  = "Apoyo";
					ExternalSecondLine = "Carga de la batería";
					LabelDay           = "día";
					LabelDays          = "días";
					LabelHour          = "hora";
					LabelHours         = "horas";
					LabelMinute        = "minuto";
					LabelMinutes       = "minutos";
					LetterDay          = "d";
					LetterHour         = "h";
					LetterMinute       = "m";
					ShortName          = "Batería";

					break;
					//-----------------------------------------------------------------------------------------------------------
					}
				//---------------------------------------------------------------------------------------------------------------
				#endregion
				//---------------------------------------------------------------------------------------------------------------
				#region // FR
				//---------------------------------------------------------------------------------------------------------------
				case "FR" :
					{
					//-----------------------------------------------------------------------------------------------------------
					BattRemaining      = "Temps restant";
					ChargedFirstLine   = "Chargée";
					ChargedSecondLine  = "Batterie chargée";
					ExternalFirstLine  = "En charge";
					ExternalSecondLine = "Batterie en charge";
					LabelDay           = "jour";
					LabelDays          = "jours";
					LabelHour          = "heure";
					LabelHours         = "heures";
					LabelMinute        = "minute";
					LabelMinutes       = "minutes";
					LetterDay          = "j";
					LetterHour         = "h";
					LetterMinute       = "m";
					ShortName          = "Batterie";

					break;
					//-----------------------------------------------------------------------------------------------------------
					}
				//---------------------------------------------------------------------------------------------------------------
				#endregion
				//---------------------------------------------------------------------------------------------------------------
				#region // IT
				//---------------------------------------------------------------------------------------------------------------
				case "IT" :
					{
					//-----------------------------------------------------------------------------------------------------------
					BattRemaining      = "Tempo rimanente";
					ExternalFirstLine  = "Supporto";
					ExternalSecondLine = "Ricarica della batteria";
					LabelDay           = "giorno";
					LabelDays          = "giorni";
					LabelHour          = "ora";
					LabelHours         = "orario";
					LabelMinute        = "minuto";
					LabelMinutes       = "minuti";
					LetterDay          = "g";
					LetterHour         = "o";
					LetterMinute       = "m";
					ShortName          = "Bateria";

					break;
					//-----------------------------------------------------------------------------------------------------------
					}
				//---------------------------------------------------------------------------------------------------------------
				#endregion
				//---------------------------------------------------------------------------------------------------------------
				#region // PT
				//---------------------------------------------------------------------------------------------------------------
				case "PT" :
					{
					//-----------------------------------------------------------------------------------------------------------
					BattRemaining      = "Tempo restante";
					ExternalFirstLine  = "Carregamento";
					ExternalSecondLine = "Carregamento da bateria";
					LabelDay           = "dia";
					LabelDays          = "dias";
					LabelHour          = "hora";
					LabelHours         = "horas";
					LabelMinute        = "minuto";
					LabelMinutes       = "minutos";
					LetterDay          = "d";
					LetterHour         = "h";
					LetterMinute       = "m";
					ShortName          = "Bateria";

					break;
					//-----------------------------------------------------------------------------------------------------------
					}
				//---------------------------------------------------------------------------------------------------------------
				#endregion
				//---------------------------------------------------------------------------------------------------------------
				#region // Other
				//---------------------------------------------------------------------------------------------------------------
				default   :
					{
					//-----------------------------------------------------------------------------------------------------------
					BattRemaining      = "Time remaining";
					ExternalFirstLine  = "Charging";
					ExternalSecondLine = "Battery charging";
					LabelDay           = "day";
					LabelDays          = "days";
					LabelHour          = "hour";
					LabelHours         = "hours";
					LabelMinute        = "minute";
					LabelMinutes       = "minutes";
					LetterDay          = "d";
					LetterHour         = "h";
					LetterMinute       = "m";
					ShortName          = "Battery";

					break;
					//-----------------------------------------------------------------------------------------------------------
					}
				//---------------------------------------------------------------------------------------------------------------
				#endregion
				//---------------------------------------------------------------------------------------------------------------
				}
			//-------------------------------------------------------------------------------------------------------------------
			}
		//***********************************************************************************************************************

		//***********************************************************************************************************************
		public static string BattRemaining      { get; private set; }
		public static string ChargedFirstLine   { get; private set; }
		public static string ChargedSecondLine  { get; private set; }
		public static string ExternalFirstLine  { get; private set; }
		public static string ExternalSecondLine { get; private set; }
		public static string LabelDay           { get; private set; }
		public static string LabelDays          { get; private set; }
		public static string LabelHour          { get; private set; }
		public static string LabelHours         { get; private set; }
		public static string LabelMinute        { get; private set; }
		public static string LabelMinutes       { get; private set; }
		public static string LetterDay          { get; private set; }
		public static string LetterHour         { get; private set; }
		public static string LetterMinute       { get; private set; }
		public static string ShortName          { get; private set; }
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
