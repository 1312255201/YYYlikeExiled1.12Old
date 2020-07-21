using EXILED;
using EXILED.Extensions;
using MEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityStandardAssets.ImageEffects;

namespace PlayerStats
{
    public class Csgo
    {
        public List<CoroutineHandle> Coroutines = new List<CoroutineHandle>();
        private bool hd;
        private bool zhunbeiyes;
        private int hdsl;
        private int jwhsl;
        Plugin plugin = new Plugin();
        private EventHandlers EventHandlers;

        public void OnRoundStart()
        {
            Map.Broadcast("CSGO模式已开启 请双方 进行配件准备 60S", 60, false);
            Coroutines.Add(Timing.RunCoroutine(ZhunBei()));
            Coroutines.Add(Timing.RunCoroutine(RenShuJianCe())); 
            zhunbeiyes = true;
        }
        private IEnumerator<float> RenShuJianCe()
        {
            for (; ; )
            {
                yield return Timing.WaitForSeconds(10f);
                jwhsl = 0;
                hdsl = 0;
                foreach(ReferenceHub referenceHub in Player.GetHubs())
                {
                    if(referenceHub.GetRole() == RoleType.ChaosInsurgency)
                    {
                        hdsl++;
                    }
                    if(referenceHub.GetRole() == RoleType.NtfLieutenant)
                    {
                        jwhsl++;
                    }
                }
                Map.Broadcast("混沌：" + hdsl + "九尾狐" + jwhsl, 3, false);

            }
        }
        private IEnumerator<float> SetHD(ReferenceHub player)
        {
            yield return Timing.WaitForSeconds(0.5f);
            player.SetRole(RoleType.ChaosInsurgency);
            yield return Timing.WaitForSeconds(0.5f);
            foreach (Inventory.SyncItemInfo itemInfo in player.GetAllItems())
            {
                player.RemoveItem(itemInfo);
            }
            player.AddItem(ItemType.GunE11SR);
            player.AddItem(ItemType.GunProject90);
            player.AddItem(ItemType.GunLogicer);
            player.AddItem(ItemType.GrenadeFlash);
            player.AddItem(ItemType.GrenadeFrag);
            player.AddItem(ItemType.Medkit);
            player.AddItem(ItemType.GunUSP);
            player.AddItem(ItemType.KeycardO5);
        }
        private IEnumerator<float> SetMtf(ReferenceHub player)
        {
            yield return Timing.WaitForSeconds(0.5f);
            player.SetRole(RoleType.NtfLieutenant);
            yield return Timing.WaitForSeconds(0.5f);
            foreach (Inventory.SyncItemInfo itemInfo in player.GetAllItems())
            {
                player.RemoveItem(itemInfo);
            }
            player.AddItem(ItemType.GunE11SR);
            player.AddItem(ItemType.GunProject90);
            player.AddItem(ItemType.GunLogicer);
            player.AddItem(ItemType.GrenadeFlash);
            player.AddItem(ItemType.GrenadeFrag);
            player.AddItem(ItemType.Medkit);
            player.AddItem(ItemType.GunUSP);
            player.AddItem(ItemType.KeycardO5);
        }

        private IEnumerator<float> ZhunBei()
        {
            yield return Timing.WaitForSeconds(1f);
            foreach (ReferenceHub referenceHub in Player.GetHubs())
            {
                if(hd == true)
                {
                    referenceHub.SetRole(RoleType.ChaosInsurgency);
                    hd = false;
                }
                else
                {
                    referenceHub.SetRole(RoleType.NtfLieutenant);
                    hd = true;
                }
            }
            yield return Timing.WaitForSeconds(1f);
            foreach(ReferenceHub referenceHub2 in Player.GetHubs())
            {
                foreach(Inventory.SyncItemInfo itemInfo in referenceHub2.GetAllItems())
                {
                    referenceHub2.RemoveItem(itemInfo);
                }
                referenceHub2.AddItem(ItemType.GunE11SR);
                referenceHub2.AddItem(ItemType.GunProject90);
                referenceHub2.AddItem(ItemType.GunLogicer);
                referenceHub2.AddItem(ItemType.GrenadeFlash);
                referenceHub2.AddItem(ItemType.GrenadeFrag);
                referenceHub2.AddItem(ItemType.Medkit);
                referenceHub2.AddItem(ItemType.GunUSP);
                referenceHub2.AddItem(ItemType.KeycardO5);

            }
            yield return Timing.WaitForSeconds(60f);
            foreach(ReferenceHub referenceHub1 in Player.GetHubs())
            {
                if(referenceHub1.GetRole() == RoleType.ChaosInsurgency)
                {
                    referenceHub1.SetPosition(Map.GetRandomSpawnPoint(RoleType.ClassD));
                }
                if(referenceHub1.GetRole() == RoleType.NtfLieutenant)
                {
                    referenceHub1.SetPosition(Map.GetRandomSpawnPoint(RoleType.NtfCommander));
                }
            }
            zhunbeiyes = false;
        }
        public void OnPlayerDeath(ref PlayerDeathEvent ev)
        {
            Map.Broadcast("[" + ev.Killer.GetRole() + "]" + ev.Killer.GetNickname() + "击杀[" + ev.Player.GetRole() + "]" + ev.Player.GetNickname(), 3, false);
        }
        public void OnRoundEnd()
        {
            EventHandlers = new EventHandlers(plugin);
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

            Timing.KillCoroutines(Coroutines);
            Coroutines.Clear();
            Events.RoundStartEvent -= OnRoundStart;
            Events.RoundEndEvent -= OnRoundEnd;
            Events.PlayerHurtEvent -= OnPlayerHurt;
            Events.CheckRoundEndEvent -= OnCheckRoundEnd;
            Events.PlayerDeathEvent -= OnPlayerDeath;
            Events.PlayerJoinEvent -= OnPlayerJoin;


        }
        public void OnPlayerJoin(PlayerJoinEvent ev)
        {
            if(zhunbeiyes == true)
            {
                if (hd == true)
                {
                    Coroutines.Add(Timing.RunCoroutine(SetHD(ev.Player)));

                    hd = false;
                }
                else
                {
                    Coroutines.Add(Timing.RunCoroutine(SetMtf(ev.Player)));

                    hd = true;
                }
            }
        }
        public void OnCheckRoundEnd(ref CheckRoundEndEvent ev)
        {
            int awa = 0;
            int qwq = 0;
            if (zhunbeiyes == true)
            {
                ev.ForceEnd = false;
            }
            else
            {
                foreach (ReferenceHub referenceHub in Player.GetHubs())
                {
                    if (referenceHub.GetRole() == RoleType.ChaosInsurgency)
                    {
                        awa++;
                    }
                    if (referenceHub.GetRole() == RoleType.NtfLieutenant)
                    {
                        qwq++;
                    }
                }
                if(awa == 0)
                {
                    ev.ForceEnd = true;
                }
                if(qwq == 0)
                {
                    ev.ForceEnd = true;
                }
            }
            

        }
        public void OnPlayerHurt(ref PlayerHurtEvent ev)
        {
            if(zhunbeiyes == true)
            {
                ev.Amount = 0;
            }
        }
    }
}
