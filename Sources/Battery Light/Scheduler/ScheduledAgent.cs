﻿//*******************************************************************************************************************************
// DEBUT DU FICHIER
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// Nom           : ScheduledAgent.cs
// Auteur        : Nicolas Dagnas
// Description   : Implémentation de l'objet ScheduledAgent
// Créé le       : 08/09/2014
// Modifié le    : 08/09/2014
//*******************************************************************************************************************************

//-------------------------------------------------------------------------------------------------------------------------------
#region Using directives
//-------------------------------------------------------------------------------------------------------------------------------
using System;
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
using Windows.ApplicationModel.Background;
//-------------------------------------------------------------------------------------------------------------------------------
#endregion
//-------------------------------------------------------------------------------------------------------------------------------

//*******************************************************************************************************************************
// Début du bloc "Scheduler"
//*******************************************************************************************************************************
namespace Scheduler
	{

	//   ####   ###   #   #  #####  ####   #   #  #      #####  #### 
	//  #      #   #  #   #  #      #   #  #   #  #      #      #   #
	//   ###   #      #####  ###    #   #  #   #  #      ###    #   #
	//      #  #   #  #   #  #      #   #  #   #  #      #      #   #
	//  ####    ###   #   #  #####  ####    ###   #####  #####  #### 

	//***************************************************************************************************************************
	// Classe ScheduledAgent
	//***************************************************************************************************************************
	#region // Déclaration et Implémentation de l'Objet
	//---------------------------------------------------------------------------------------------------------------------------
	/// <summary>
	/// Définit le comportement de l'agent.
	/// </summary>
	//---------------------------------------------------------------------------------------------------------------------------
	public sealed class ScheduledAgent : IBackgroundTask
		{
		//***********************************************************************************************************************
		/// <summary>
		/// Agent qui exécute une tâche planifiée.
		/// </summary>
		/// <param name="task">La tâche appelée.</param>
		//-----------------------------------------------------------------------------------------------------------------------
		public void Run ( IBackgroundTaskInstance taskInstance ) { BatteryTile.Refresh (); }
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
