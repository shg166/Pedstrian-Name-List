using System;
using System.Reflection;
using UnityEngine;
using ColossalFramework.UI;
using ICities;

namespace JP_PedstrianNameList
{
	public class JP_PedstrianNameList : IUserMod
	{

		public string Name
		{
			get { return "JP Pedstrian Name List (CNL) v1.0"; }
		}

		public string Description
		{
			get { return "Custom Name Listsを使って、DLC Plazas & Promenadesの歩行者エリア名を変更します"; }
		}

	}
}
