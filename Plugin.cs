using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using EXILED;
using Harmony;

namespace PlayerStats
{
	public class Plugin : EXILED.Plugin
	{
		public EventHandlers EventHandlers;

		internal static string StatFilePath =
			Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Plugins"),
				"新手服EX版本插件");
		public override string getName => "YYYlike";
		private HarmonyInstance instance;
		public static int InstanceNumber = 0;
		public override void OnEnable()
		{
			if (!Directory.Exists(StatFilePath))
				Directory.CreateDirectory(StatFilePath);



			Log.Info($"开始加载 {getName}..");
			EventHandlers = new EventHandlers(this);
			Events.WaitingForPlayersEvent += EventHandlers.OnWaitingForPlayers;
			Events.RoundStartEvent += EventHandlers.OnRoundStart;
			Events.RoundEndEvent += EventHandlers.OnRoundEnd;
			Events.PlayerJoinEvent += EventHandlers.OnPlayerJoin;
			Events.PlayerDeathEvent += EventHandlers.OnPlayerDeath;
			Events.GrenadeThrownEvent += EventHandlers.OnThrowGrenade;
			Events.UseMedicalItemEvent += EventHandlers.OnMedicalItem;
			Events.TeamRespawnEvent += EventHandlers.OnTeamRespawn;
			Events.ConsoleCommandEvent += EventHandlers.OnConsoleCommand;
			Events.PocketDimDeathEvent += EventHandlers.OnPocketDimDeath;
			Events.CheckEscapeEvent += EventHandlers.OnCheckEscape;
			Events.DoorInteractEvent += EventHandlers.OnDoorInteract;
			Events.Scp106ContainEvent += EventHandlers.OnScp106Contain;
			Events.CheckRoundEndEvent += EventHandlers.OnCheckRoundEnd;
			Events.DropItemEvent += EventHandlers.OnDropItem;
			Events.ShootEvent += EventHandlers.OnShoot;
			Events.PickupItemEvent += EventHandlers.OnPickupItem;
			Events.PlayerHurtEvent += EventHandlers.OnPlayerHurt;
			Events.PocketDimEscapedEvent += EventHandlers.OnPocketDimEscaped;
			Events.SetClassEvent += EventHandlers.OnSetClass;
			Events.PlayerSpawnEvent += EventHandlers.OnPlayerSpawn;
			Events.Scp079LvlGainEvent += EventHandlers.OnScp079LvlGain;
			Events.GeneratorUnlockEvent += EventHandlers.OnGeneratorUnlock;
			Events.PlayerLeaveEvent += EventHandlers.OnPlayerLeave;
			Events.WarheadCancelledEvent += EventHandlers.ONWarheadCancelled;
			Events.Scp914KnobChangeEvent += EventHandlers.On914KnobChange;
			Events.Scp096EnrageEvent += EventHandlers.OnScp096Enrage;
			Events.WarheadDetonationEvent += EventHandlers.OnWarheadDetonation;
			Events.RemoteAdminCommandEvent += EventHandlers.OnRemoteAdminCommand;

			Log.Info($"{getName} 加载完毕.");





		}

		public override void OnDisable()
		{

			Events.WaitingForPlayersEvent -= EventHandlers.OnWaitingForPlayers;
			Events.RoundStartEvent -= EventHandlers.OnRoundStart;
			Events.RoundEndEvent -= EventHandlers.OnRoundEnd;
			Events.PlayerJoinEvent -= EventHandlers.OnPlayerJoin;
			Events.PlayerDeathEvent -= EventHandlers.OnPlayerDeath;
			Events.GrenadeThrownEvent -= EventHandlers.OnThrowGrenade;
			Events.UseMedicalItemEvent -= EventHandlers.OnMedicalItem;
			Events.TeamRespawnEvent -= EventHandlers.OnTeamRespawn;
			Events.ConsoleCommandEvent -= EventHandlers.OnConsoleCommand;
			Events.PocketDimDeathEvent -= EventHandlers.OnPocketDimDeath;
			Events.CheckEscapeEvent -= EventHandlers.OnCheckEscape;
			Events.DoorInteractEvent -= EventHandlers.OnDoorInteract;
			Events.Scp106ContainEvent -= EventHandlers.OnScp106Contain;
			Events.CheckRoundEndEvent -= EventHandlers.OnCheckRoundEnd;
			Events.ShootEvent -= EventHandlers.OnShoot;
			Events.DropItemEvent -= EventHandlers.OnDropItem;
			Events.PickupItemEvent -= EventHandlers.OnPickupItem;
			Events.PlayerHurtEvent -= EventHandlers.OnPlayerHurt;
			Events.SetClassEvent -= EventHandlers.OnSetClass;
			Events.PlayerSpawnEvent -= EventHandlers.OnPlayerSpawn;
			Events.Scp079LvlGainEvent -= EventHandlers.OnScp079LvlGain;
			Events.GeneratorUnlockEvent -= EventHandlers.OnGeneratorUnlock;
			Events.PlayerLeaveEvent -= EventHandlers.OnPlayerLeave;
			Events.WarheadCancelledEvent -= EventHandlers.ONWarheadCancelled;
			Events.Scp914KnobChangeEvent -= EventHandlers.On914KnobChange;
			Events.Scp096EnrageEvent -= EventHandlers.OnScp096Enrage;
			Events.WarheadDetonationEvent -= EventHandlers.OnWarheadDetonation;
			Events.RemoteAdminCommandEvent -= EventHandlers.OnRemoteAdminCommand;

			EventHandlers = null;
		}

		public override void OnReload()
		{
			
		}



	}
}