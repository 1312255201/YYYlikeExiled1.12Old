using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using CommandSystem.Commands;
using EXILED;
using EXILED.ApiObjects;
using EXILED.Extensions;
using Grenades;
using MEC;
using Mirror;
using Telepathy;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.Assertions.Must;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Data;
using System.Collections;

namespace PlayerStats
{
    public class EventHandlers
    {
        public static string url = "http://127.0.0.1:4578/";

        private int scp079id = -1;
        private bool h;
        private bool choise;

        private ReferenceHub scp;
        private bool die;
        private bool start;
        private int int222;
        private DateTime maxtime;
        public static List<String> scp_999 = new List<String>();



        private string SCP173;
        private string SCP049;
        private string SCP079;
        private string SCP096;
        private string SCP939_89;
        private string SCP939_53;
        private string SCP106;
        private int s173;
        public int s049;
        private int s096;
        private int s939_53;
        private int s939_89;
        private int s106;
        private int KillerID;
        private int PlayerID;
        private int RoleSet = 0;
        public bool roundstart = false;
        public int[] GuardType = new int[200];
        public int Guardnum = 0;
        public int count = 0;
        public DateTime updatatimer = DateTime.Now;
        public int deadtimer = 0;
        public bool starttimer = false;



        public bool deadtime = false;
        public int count2 = 0;
        private int waring1;
        private int playernum = 0;
        public bool waring = false;
        public int[] touxiang = new int[0x65];
        private int round = 0;
        public int chaos = 0;
        public int mtf = 0;
        public int mtfchange = 0;
        public int chaoschange = 0;
        private int coldtime = 0;
        private int coldtime2 = 2;
        private bool coldbc = false;
        private bool coldtb = false;
        private int ini10;
        private int xp;
        private int lv;
        private bool coldwait233;
        private bool Dio1;
        private bool sjtz1;
        private bool sjtz2;
        private Thread cd;


        private bool ylb1;


        private DateTime updatatimer7 = DateTime.Now;
        private int tiems;
        private int scp073id;
        private bool scp076yes;
        private bool scp076iteam;
        private int scp076id;
        private bool xhsnb;
        private int xhsnb2;
        private int scp2818id;
        private bool scp2818pick;
        private ReferenceHub hdjjs;
        private int hdjjsid;
        private int times2;
        private bool scp1143a;
        private int scp1143id;
        private ReferenceHub jwhng;
        private int jwhngid;
        private int times;
        private bool bpb;
        private bool jljy1;
        private bool jljyzb;
        private ReferenceHub scp181;
        private int scp181id;
        private ReferenceHub cxk;
        public bool cxkyes;
        private bool cxkflash;
        public int cxkid;
        //181的变量测试

        public bool jntm;

        public int scp817id;
        private ReferenceHub scp817;
        public bool scp817yes;
        public int D9341id;
        private bool d9341flash;
        public bool D9341yes;
        public int times1 = 0;
        public bool jntmlq;
        public int times3 = 0;
        private ReferenceHub scp2006;
        private int scp2006id;
        private bool scp035health;
        public int scp035id;
        private bool scp035item2;
        private int times5 = 1;
        private int scpqblid2;
        private ReferenceHub scpqbl;
        private string scpqblid;
        private bool qblcq2;
        private int scp914mid;
        private int scp939id;
        private bool jkl;
        private string jklid;

        private ReferenceHub xywj;
        private string xywjid;
        private bool bscp79;
        private int jwhhkid;
        private bool jwhngyes;
        private bool jwhngitem;
        private bool jwhngshuachu;
        private bool hrss;
        private int hktime;
        private bool csm;
        private int csmtime;
        private bool a127;
        private bool a127c;
        private int a127b;
        private ReferenceHub xtd;
        private int xtdid;
        private bool stealcd;
        private bool scp457a;
        private bool scp457die;
        private int scp457id;
        private int time2;
        private int time3;
        private bool scp005;
        private int scp005aid;
        private bool scp073a;
        private bool scp073zb = true;
        private bool a127d;
        private bool scp650yes;
        private ReferenceHub scp650;
        private int scp650id;
        private bool scp3108pick;
        private int scp3108playerid;
        private bool scp3108shotyes;
        private bool scp1577pick;
        private int gjtr;
        private bool bhsx;
        private int njsxtimes;
        private bool yshkq;
        private int peaple;
        private bool sjqx;
        private DateTime upwait = DateTime.Now;
        private readonly Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;
        public Dictionary<string, Stats> Stats = new Dictionary<string, Stats>();
        public List<CoroutineHandle> Coroutines = new List<CoroutineHandle>();
        public List<int> 小僵尸id = new List<int>();
        private Thread pmd;
        private ReferenceHub D9341;
        private RoleType D9341js;
        private List<string> scp2006a = new List<string>();
        private ReferenceHub scp035;
        private ReferenceHub scp914m;
        private ReferenceHub scp076;
        private List<ReferenceHub> player233 = new List<ReferenceHub>();
        private List<ReferenceHub> player22 = new List<ReferenceHub>();
        private List<GameObject> doorlist = new List<GameObject>();
        
        private List<string> hd = new List<string>();
        private List<int> jw = new List<int>();
        private ReferenceHub jwhhk;
        private Vector3 hkzb;
        private ReferenceHub scp073;
        private List<Inventory.SyncItemInfo> D9341Item;
        private Vector3 D9341zb;
        private ReferenceHub scp457;
        private List<string> Dio2 = new List<string>(); 
        private ReferenceHub scpqbl3;
        private ReferenceHub qblcq;
        private List<string> HDZHG2 = new List<string>();
        private List<int> LLBS233 = new List<int>();
        private List<Door> door2 = new List<Door>();
        private List<string> jljy2 = new List<string>();
        private List<string> scp682 = new List<string>();
        private List<string> ylb2 = new List<string>();
        private List<int> bpb2 = new List<int>();
        private List<int> scp1577id = new List<int>();
        private ReferenceHub scp2818;
        private ReferenceHub Dio;
        private List<ReferenceHub> player5 = new List<ReferenceHub>();
        private List<Vector3> pos1 = new List<Vector3>();
        private Vector3 scp1577pos;
        private List<ReferenceHub> playerqwq = new List<ReferenceHub>();
        private ReferenceHub scp1143;
        private ReferenceHub HDZHG;
        private ReferenceHub mrfish;
        private ReferenceHub jljy;
        private Vector3 scp457b;
        private ReferenceHub ylb;
        private Vector3 pos3;
        private ReferenceHub scp106a;
        private List<ReferenceHub> scpd79 = new List<ReferenceHub>();

        private Vector3 LCZ; 
        private Vector3 scp3108shotatplayerpos;
        private int d = 0;
        private int s;
        private int card;
        private bool scp999yes;
        private int ragdolltime;
        private int itemtime; 
        private bool scp999tp;
        private List<ReferenceHub> playerdio = new List<ReferenceHub>();
        private List<ReferenceHub> ljfwj = new List<ReferenceHub>();
        
        private bool scp035goout;
        private bool diyicizhixingzheli;
        private bool xitonghedan;
        private Vector3 pos5;
        private bool jwhngwufashanghai;
        private bool bscd;
        private ReferenceHub hpsz;
        private int hpszid;
        private ReferenceHub scp550;
        private int scp550id;
        private bool scp550yes;
        private bool scp550shuachu;
        private List<Inventory.SyncItemInfo> scp035item;
        private bool scp035yes;
        private bool mzyes;
        private ReferenceHub mz;
        private int mzid;
        private List<Inventory.SyncItemInfo> item;
        private float health;
        private bool meitunshi;
        private int tssj;
        private int scp550lv;
        private int tssl;
        private bool scp79;
        private float scp457health;
        private bool fkyyshuachu;
        private bool fkyyzyes;
        private ReferenceHub fkyyz;
        private int fkyyzid;
        private bool ljfuse;
        private int fkyyzcardint;
        private bool bindljf;
        private bool jzsjuse;
        private bool bindjzsj;
        private bool tysuse;
        private bool bindtys;
        private bool zybuse;
        private ReferenceHub 误杀玩家;
        private int Gears博士id;

        public ReferenceHub Gears博士;
        
        private Transform intercomeArea = null;
        private bool 中国制造;
        private bool lxyes;
        private ReferenceHub scp49j;
        private int scp49jid;
        private bool scp49jyes;
        private int tuolikadianid;
        private int scp457sh;
        private Socket socketwatch;
        private Dictionary<string, Socket> clientConnectionItems;
        private int timesjw;
        private int timestop;
        private string 事件;
        private string 时间;
        private string 地点;
        private string 人物;
        private string 句子;
        private string 缺少;
        private ReferenceHub rhdzzwj;
        private bool rhdyes;
        private int tlid;
        private int g;
        Csgo csgo = new Csgo();

        private Transform IntercomArea
        {
            get
            {
                if (intercomeArea == null)
                    intercomeArea = typeof(Intercom).GetField("area", BindingFlags.NonPublic | BindingFlags.Instance)?.GetValue(Intercom.host) as Transform;

                if (intercomeArea == null)
                    throw new MissingFieldException("找不到 通信频段.");
                return intercomeArea;
            }
        }
        public void OnRemoteAdminCommand(ref RACommandEvent ev)
        {
            if(ev.Command == "csgotest")
            {
                End();
                Events.RoundStartEvent += csgo.OnRoundStart;
                Events.RoundEndEvent += csgo.OnRoundEnd;
                Events.PlayerHurtEvent += csgo.OnPlayerHurt;
                Events.CheckRoundEndEvent += csgo.OnCheckRoundEnd;
                Events.PlayerDeathEvent += csgo.OnPlayerDeath;
                Events.PlayerJoinEvent += csgo.OnPlayerJoin;


                Events.WaitingForPlayersEvent -= this.OnWaitingForPlayers;
                Events.RoundStartEvent -= this.OnRoundStart;
                Events.RoundEndEvent -= this.OnRoundEnd;
                Events.PlayerJoinEvent -= this.OnPlayerJoin;
                Events.PlayerDeathEvent -= this.OnPlayerDeath;
                Events.GrenadeThrownEvent -= this.OnThrowGrenade;
                Events.UseMedicalItemEvent -= this.OnMedicalItem;
                Events.TeamRespawnEvent -= this.OnTeamRespawn;
                Events.ConsoleCommandEvent -= this.OnConsoleCommand;
                Events.PocketDimDeathEvent -= this.OnPocketDimDeath;
                Events.CheckEscapeEvent -= this.OnCheckEscape;
                Events.DoorInteractEvent -= this.OnDoorInteract;
                Events.Scp106ContainEvent -= this.OnScp106Contain;
                Events.CheckRoundEndEvent -= this.OnCheckRoundEnd;
                Events.ShootEvent -= this.OnShoot;
                Events.DropItemEvent -= this.OnDropItem;
                Events.PickupItemEvent -= this.OnPickupItem;
                Events.PlayerHurtEvent -= this.OnPlayerHurt;
                Events.SetClassEvent -= this.OnSetClass;
                Events.PlayerSpawnEvent -= this.OnPlayerSpawn;
                Events.Scp079LvlGainEvent -= this.OnScp079LvlGain;
                Events.GeneratorUnlockEvent -= this.OnGeneratorUnlock;
                Events.PlayerLeaveEvent -= this.OnPlayerLeave;
                Events.WarheadCancelledEvent -= this.ONWarheadCancelled;
                Events.Scp914KnobChangeEvent -= this.On914KnobChange;
                Events.Scp096EnrageEvent -= this.OnScp096Enrage;
                Events.WarheadDetonationEvent -= this.OnWarheadDetonation;
                Events.RemoteAdminCommandEvent -= this.OnRemoteAdminCommand;
            }
        }
        public void SetPlayerScale(GameObject target, float x, float y, float z)
        {
            try
            {
                NetworkIdentity identity = target.GetComponent<NetworkIdentity>();
                

                target.transform.localScale = new Vector3(1 * x, 1 * y, 1 * z);

                ObjectDestroyMessage destroyMessage = new ObjectDestroyMessage();
                destroyMessage.netId = identity.netId;


                foreach (GameObject player in PlayerManager.players)
                {
                    if (player == target)
                        continue;

                    NetworkConnection playerCon = player.GetComponent<NetworkIdentity>().connectionToClient;

                    playerCon.Send(destroyMessage, 0);

                    object[] parameters = new object[] { identity, playerCon };
                    typeof(NetworkServer).InvokeStaticMethod("SendSpawnMessage", parameters);
                }
            }
            catch (Exception e)
            {
                Log.Info($"大小设置失败: {e}");
            }
        }
        public void ONWarheadCancelled(WarheadCancelEvent ev)
        {
            if (xitonghedan == true)
            {
                ev.Player.Broadcast(2, "<color=red>[警告]</color>\n<color=lime>系统核弹无法关闭</color>", false);
                ev.Allow = false;
            }
            if(ev.Allow == true)
            {
                timestop++;
                Map.Broadcast("<color=red>[警告]</color>\n<color=lime>核弹当前被关闭" + timestop + "超过25次将无法关闭</color>",5,false);
            }
            if(timestop >25)
            {
                ev.Player.Broadcast(2, "<color=red>[警告]</color>\n<color=lime>核弹生气了</color>", false);
                ev.Allow = false;
            }

        }
        public void OnWarheadDetonation()
        {
            Map.Broadcast("<color=red>[警告]</color>\n<color=lime>地表核弹即将开启 开启后将会消灭全部 SCP和人类</color>", 10, false);
            Coroutines.Add(Timing.RunCoroutine(Dbhd()));

        }
        private IEnumerator<float> Dbhd()
        {
            yield return Timing.WaitForSeconds(600f);
            foreach(ReferenceHub referenceHub in Player.GetHubs())
            {
                referenceHub.SetRole(RoleType.Spectator);
            }
        }
        public void OnWaitingForPlayers()
        {
            pmd = new Thread(PMD);
            pmd.Start();

            
            Coroutines.Add(Timing.RunCoroutine(SecondCounter()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter2()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter3()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter4()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter5()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter6()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter7()));

            Coroutines.Add(Timing.RunCoroutine(SecondCounter9()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter11()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter12()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter13()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter14()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter15()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter16()));

            Coroutines.Add(Timing.RunCoroutine(SecondCounter18()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter19()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter17()));

            Coroutines.Add(Timing.RunCoroutine(SecondCounter21()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter22()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter23()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter27()));
            Coroutines.Add(Timing.RunCoroutine(GuangBoSHhi()));
        }
        
        private IEnumerator<float> HdjjsCD()
        {
            hdjjs.Broadcast(1, "<color=yelow>装弹中</color>\n5");
            yield return Timing.WaitForSeconds(1f);
            hdjjs.Broadcast(1, "<color=yelow>装弹中</color>\n4");
            yield return Timing.WaitForSeconds(1f); 
            hdjjs.Broadcast(1, "<color=yelow>装弹中</color>\n3");
            yield return Timing.WaitForSeconds(1f); 
            hdjjs.Broadcast(1, "<color=yelow>装弹中</color>\n2");
            yield return Timing.WaitForSeconds(1f); 
            hdjjs.Broadcast(1, "<color=yelow>装弹中</color>\n1");
            yield return Timing.WaitForSeconds(1f);
            hdjjs.AddItem(ItemType.GunE11SR);
        }

        private IEnumerator<float> Xywjsx()
        {
            yield return Timing.WaitForSeconds(90f);
            xywj = null;
            xywjid = null;

        }
        
        private IEnumerator<float> GuanZhanYouXi()
        {
            for (; ; )
            {
                yield return Timing.WaitForSeconds(15f);
                foreach(ReferenceHub referenceHub in Player.GetHubs())
                {
                    if(referenceHub.GetRole() == RoleType.Spectator)
                    {
                        句子 = 时间 + 地点 + 人物 + 事件;
                        if(时间 == "")
                        {
                            缺少 = "时间 输入.jl 内容补充内容";
                        }
                        else if(地点 == "")
                        {
                            缺少 = "地点 输入.jl 内容补充内容";
                        }
                        else if (人物 == "")
                        {
                            缺少 = "人物 输入.jl 内容补充内容";
                        }
                        else if (事件 == "")
                        {
                            缺少 = "事件 输入.jl 内容补充内容";
                        }
                        else
                        {
                            缺少 = "输入.jlck开启下一回合";
                        }
                        referenceHub.Broadcast(5, "当前句子" + 句子 + "\n" + "当前缺少" + 缺少,false);
                    }
                }

            }
        }

        private IEnumerator<float> GuangBoSHhi()
        {
            for (; ; )
            {
                Intercom.host.CustomContent = "你好呀 欢迎来到广播室(*^▽^*)";
                yield return Timing.WaitForSeconds(10f);
                Intercom.host.CustomContent = "现在时间是"+ DateTime.Now;
                yield return Timing.WaitForSeconds(10f);
                Intercom.host.CustomContent = "插件版本是"+DateTime.Today+"'ω'";
                yield return Timing.WaitForSeconds(10f);
                Intercom.host.CustomContent = "?( ??˙ω˙?? ?)";
                yield return Timing.WaitForSeconds(10f);
                Intercom.host.CustomContent = "(*^▽^*)请河蟹游戏 友善对待他人";
                yield return Timing.WaitForSeconds(10f);
                Intercom.host.CustomContent = "服主QQ:1312255201(￣▽￣)~*交个朋友";
                yield return Timing.WaitForSeconds(10f);
                Intercom.host.CustomContent = "￣へ￣进来还不加群打屎你";
                yield return Timing.WaitForSeconds(10f);
                Intercom.host.CustomContent = "<*))>>=< 最好可以给我money没错就是这条鱼";
                yield return Timing.WaitForSeconds(10f);
                Intercom.host.CustomContent = "⊂(ο･㉨･ο)⊃ 阿巴阿巴???";
                yield return Timing.WaitForSeconds(10f);
                Intercom.host.CustomContent = "(≧▽≦)/下面是重复的了 ???";
                yield return Timing.WaitForSeconds(10f);


                
            }

        }
        private IEnumerator<float> Remove492(int playerid)
        {
            yield return Timing.WaitForSeconds(10f);
            小僵尸id.Remove(playerid);
        }
        private IEnumerator<float> Badapple(string weizhi)
        {
            int time333 = 1;
            for (; ; )
            {
                StreamReader sr = new StreamReader(@"D:\\badapple\\"+ weizhi + "\\" + time333+".txt");
                yield return Timing.WaitForSeconds(0.03f);
                Intercom.host.CustomContent = sr.ReadToEnd();
                time333++;
                if(time333 >= 6571)
                {
                    break;
                    
                }
            }
        }
        private IEnumerator<float> SetNineFox()
        {
            yield return Timing.WaitForSeconds(1f);
            timesjw++;
            if (timesjw == 1)
            {
                
            }
            if (timesjw == 2)
            {
                
                Map.Broadcast("<color=#66FF00>机动特遣队</color><color=#3333FF>九尾狐</color><color=#FF0000>蔡徐坤</color><color=#66FF00>小队已经进入设施</color>\n<color=#66FF00>请所有人员乖乖站好♂投入九尾狐怀抱</color>", 7, false);
            }
            if (timesjw == 3)
            {
                Map.Broadcast("<color=#66FF00>机动特遣队</color><color=#3333FF>九尾狐</color><color=#FF0000>九尾大军</color><color=#66FF00>小队已经进入设施</color>\n<color=#66FF00>请所有人员乖乖站好♂投入九尾狐怀抱</color>", 7,  false);
            }
            if (timesjw == 4)
            {
               Map.Broadcast("<color=#66FF00>机动特遣队</color><color=#3333FF>九尾狐</color><color=#FF0000>最差的一届九尾</color><color=#66FF00>小队已经进入设施</color>\n<color=#66FF00>请所有人员乖乖站好♂投入九尾狐怀抱</color>", 7,  false);
            }
            if (timesjw == 5)
            {
                Map.Broadcast("<color=#66FF00>机动特遣队</color><color=#3333FF>九尾狐</color><color=#FF0000>炮灰</color><color=#66FF00>小队已经进入设施</color>\n<color=#66FF00>请所有人员乖乖站好♂投入九尾狐怀抱</color>", 7,  false);
            }
            if (timesjw == 6)
            {
                Map.Broadcast("<color=#66FF00>机动特遣队</color><color=#3333FF>九尾狐</color><color=#FF0000>顺丰快递</color><color=#66FF00>小队已经进入设施</color>\n<color=#66FF00>您的快递已到请签收</color>", 7, false);
            }
            if (timesjw == 7)
            {
                Map.Broadcast("<color=#66FF00>机动特遣队</color><color=#3333FF>九尾狐</color><color=#FF0000>圆通快递</color><color=#66FF00>小队已经进入设施</color>\n<color=#66FF00>您的快递已到请签收</color>", 7, false);
            }
            if (timesjw == 8)
            {
                Map.Broadcast("<color=#66FF00>机动特遣队</color><color=#3333FF>九尾狐</color><color=#FF0000>宅急送</color><color=#66FF00>小队已经进入设施</color>\n<color=#66FF00>您的快递已到请签收</color>", 7,  false);
            }
            if (timesjw == 9)
            {
                Map.Broadcast("<color=#66FF00>机动特遣队</color><color=#3333FF>九尾狐</color><color=#FF0000>SCP106迫害小分队</color><color=#66FF00>小队已经进入设施</color>\n<color=#66FF00>您的快递已到请签收</color>", 7,  false);
            }
            if (timesjw == 10)
            {
                Map.Broadcast("<color=#66FF00>机动特遣队</color><color=#3333FF>九尾狐</color><color=#FF0000>德国boy</color><color=#66FF00>小队已经进入设施</color>\n<color=#66FF00>您的快递已到请签收</color>", 7, false);
            }
        }
        private IEnumerator<float> Hdjjs()
        {
            yield return Timing.WaitForSeconds(1f);
            foreach(Inventory.SyncItemInfo syncItemInfo in hdjjs.GetAllItems())
            {
                hdjjs.RemoveItem(syncItemInfo);
            }
            hdjjs.AddItem(ItemType.Adrenaline);
            hdjjs.AddItem(ItemType.Adrenaline);
            hdjjs.AddItem(ItemType.Medkit);
            hdjjs.AddItem(ItemType.GunE11SR);
            hdjjs.AddItem(ItemType.Flashlight);
            hdjjs.AddItem(ItemType.GunUSP);
            hdjjs.Broadcast(5, "你是<color=yellow>混沌狙击手</color>\n你有高额伤害但是 有五秒攻击延时");
        }

        private IEnumerator<float> RenWuFenPei()
        {
            yield return Timing.WaitForSeconds(5f);
            foreach (ReferenceHub referenceHub in Player.GetHubs())
            {
                if (referenceHub.GetRole() == RoleType.Scientist)
                {
                    if (s == 0)
                    {
                        scpqbl = referenceHub;
                        scpqblid = scpqbl.GetUserId();
                    }
                    if (s == 1)
                    {
                        int yes = new System.Random().Next(1, 100);
                        if (yes >= 60)
                        {
                            scp914m = referenceHub;
                            Setrank_new("SCP914-M", "pink", scp914m);
                            scp914mid = scp914m.GetPlayerId();
                            scp914m.Broadcast(10, "你是[<color=red>SCP914-M</color>]\n你就是914的化身", false);
                        }
                    }
                    if (s == 2)
                    {
                        scp076 = referenceHub;
                        scp076iteam = true;
                        scp076id = scp076.GetPlayerId();
                        Setrank_new("SCP-076", "red", scp076);
                        scp076yes = true;
                        scp076.Broadcast(10, "[<color=red>SCP-076</color>]\n<color=lime>你有强大的SCP抗性以及子弹抗性，你没有卡请等待其他人为你开门</color>", false);
                        foreach (Inventory.SyncItemInfo item in scp076.GetAllItems())
                        {
                            scp076.RemoveItem(item);
                        }
                    }
                    if (s == 3)
                    {
                        scp650yes = true;
                        scp650 = referenceHub;
                        scp650.SetRole(RoleType.Scp173);
                        scp650.SetHealth(1);
                        scp650id = scp650.GetPlayerId();
                        scp650.SetGodMode(true);
                        Setrank_new("SCP-650", "red", scp650);
                        scp076.Broadcast(10, "[<color=red>SCP-650</color>]\n<color=lime>你是无敌的但是你没有伤害 你的责任就是吓人qwq</color>", false);
                    }
                    if (s == 4)
                    {
                        hpsz = referenceHub;
                        hpszid = hpsz.GetPlayerId();
                    }
                    if(s == 5)
                    {
                        Gears博士 = referenceHub;
                        Gears博士.Broadcast(10, "<color=yellow>欢迎您Gears博士\n特殊技能：无法被173秒杀</color>");
                        Gears博士id = Gears博士.GetPlayerId();
                        Setrank_new("Gears博士", "yellow", Gears博士);
                    }
                    s++;
                }
                if(referenceHub.GetRole() == RoleType.FacilityGuard)
                {
                    if(g == 0)
                    {
                        if (scp999yes == true)
                        {
                            scp = referenceHub;
                            die = false;
                            ScpSpawn();
                            scp999yes = false;
                        }
                    }
                    if (g == 1)
                    {
                    }
                    g++;
                }
                if (referenceHub.GetPlayerId() != D9341id)
                {
                    if (referenceHub.GetRole() == RoleType.ClassD)
                    {
                        if (d == 0)
                        {
                            scp181 = referenceHub;
                            scp181id = referenceHub.GetPlayerId();
                            card = new System.Random().Next(1, 11);
                            Log.Info("测试5");
                            Log.Info(card.ToString());
                            Setrank_new("scp181", "pink", scp181);
                            scp181.Broadcast(10, "你是[<color=red>SCP-181</color>]\n正在为你分配一张初始卡片你有20%几率捡起卡升级 次数无限 你可以人肉开门2次加油哦", false);
                            scp181.Broadcast(10, "[<color=red>SCP-181</color>]\n你还可以合成枪 你也可以合成闪光弹", false);

                        }
                        if (d == 1)
                        {
                            cxk = referenceHub;
                            cxkid = cxk.GetPlayerId();
                            cxkyes = true;
                            cxkflash = true;
                            Setrank_new("蔡徐坤", "red", cxk);
                            cxk.Broadcast(10, "你是[<color=red>SCP-蔡徐坤</color>]\n<color=lime>丢下手电筒使用技能鸡你太美</color>", false);
                        }
                        if (d == 2)
                        {
                            scp817 = referenceHub;
                            scp817yes = true;
                            scp817id = scp817.GetPlayerId();
                            Setrank_new("SCP817", "red", scp817);
                            scp817.Broadcast(10, "你是[<color=red>SCP-817</color>]\n<color=lime>150秒变换一次身份</color>", false);
                        }
                        if (d == 3)
                        {
                            D9341 = referenceHub;
                            D9341js = RoleType.ClassD;
                            D9341id = D9341.GetPlayerId();
                            d9341flash = true;
                            Setrank_new("D-9341", "red", D9341);
                            D9341.Broadcast(6, "你是[<color=red>D-9341</color>]<color=lime>你有存档能力 丢掉闪光弹</color><color=red>(打开背包右键不是左键扔出去)</color><color=lime>存档</color>\n<color=lime>死亡或丢手电会回档一共5次机会</color>", false);
                        }
                        if (d == 4)
                        {
                            scp2006 = referenceHub;
                            scp2006id = scp2006.GetPlayerId();
                            scp2006.Broadcast(10, "你是[<color=red>SCP-2006</color>]\n<color=lime>丢下一个硬币就会被随机传送到一个地方</color>", false);
                            Coroutines.Add(Timing.RunCoroutine(Scp2006coin()));
                            scp2006a.Add(scp2006.GetUserId());
                        }
                        if (d == 5)
                        {
                            scp035 = referenceHub;
                            scp035.Broadcast(10, "你是[<color=red>SCP035</color>]\n<color=lime>HP:300</color><color=red>杀掉一个人后 靠近尸体附身他的人物</color><color=red>每5秒扣除5HP 附身后HP恢复为500</color>", false);
                            scp035health = true;
                            scp035id = scp035.GetPlayerId();
                            scp035item2 = true;
                            scp035.AddItem(ItemType.GunUSP);
                        }
                        if (d == 6)
                        {
                            xtd = referenceHub;
                            xtdid = xtd.GetPlayerId();
                            xtd.Broadcast(10, "你是[<color=red>小偷</color>]\n<color=lime>输入.steal偷取物品300s一次</color>", false);
                            Setrank_new("小偷", "lime", xtd);
                        }
                        d++;
                    }
                }
                if(referenceHub.GetRole() == RoleType.Scp096)
                {
                    Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(referenceHub, 1500)));
                }
                if ((referenceHub.GetRole() == RoleType.Scp173)&&(referenceHub.GetPlayerId()!= scp650id))
                {
                    Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(referenceHub, 4200)));
                }
                if(referenceHub.GetRole() == RoleType.Scp049)
                {
                    Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(referenceHub, 3200)));

                }
            }
        }
        private IEnumerator<float> SecondCounter28()
        {
            yield return Timing.WaitForSeconds(2f);
            foreach(Inventory.SyncItemInfo item2 in D9341.GetAllItems())
            {
                D9341.RemoveItem(item2);
            }
            foreach (Inventory.SyncItemInfo item2 in D9341Item)
            {
                D9341.AddItem(item2);
            }
            D9341.SetPosition(D9341zb);
        }
        private IEnumerator<float> RunRestoreMaxHp(ReferenceHub player, int maxHp)
        {
            yield return Timing.WaitForSeconds(0.1f);
            
            player.playerStats.maxHP = maxHp;
            player.SetHealth(maxHp);
        }
        private IEnumerator<float> SecondCounter25()
        {
            yield return Timing.WaitForSeconds(2f);
            foreach (Inventory.SyncItemInfo syncItemInfo in jwhng.GetAllItems())
            {
                jwhng.RemoveItem(syncItemInfo);
            }

            foreach (Inventory.SyncItemInfo syncItemInfo in item)
            {
                jwhng.AddItem(syncItemInfo);
            }

            jwhng.SetHealth(health);
            bscd = true;
        }
        private IEnumerator<float> SecondCounter24()
        {
            yield return Timing.WaitForSeconds(2f);
            Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(scp035, 500)));

            foreach (Inventory.SyncItemInfo item in scp035.GetAllItems())
            {
                scp035.RemoveItem(item);
            }
            foreach (Inventory.SyncItemInfo item in scp035item)
            {
                scp035.AddItem(item);
            }
        }
        private IEnumerator<float> Wshf()
        {
            yield return Timing.WaitForSeconds(10f);

            误杀玩家.SetPosition(Map.GetRandomSpawnPoint(RoleType.NtfCadet));

        }
        private IEnumerator<float> Zgzz()
        {
            yield return Timing.WaitForSeconds(50f);

            中国制造 = false;
        }
        private IEnumerator<float> Jwhngwufashanghai()
        {
            yield return Timing.WaitForSeconds(120f);
            jwhngwufashanghai = false;
            jwhng.ClearBroadcasts();
            jwhng.Broadcast(10, "<color=red>你现在可以变成混沌攻击九尾狐了 右键闪光弹 或者输入.wz</color>", false);
        }

        private IEnumerator<float> SecondCounter23()
        {
            for (; ; )
            {
                foreach (ReferenceHub referenceHub1 in Player.GetHubs())
                {
                    if (referenceHub1.GetHealth() < 0)
                    {
                        referenceHub1.SetRole(RoleType.Spectator);
                    }
                }
                if(scp035yes == true)
                {
                    scp035.AddHealth(-10);
                    if(scp035.GetHealth() < 0)
                    {
                        scp035.SetRole(RoleType.Spectator);
                        scp035id = 0;
                        scp035goout = false;
                        scp035yes = false;
                        scp035 = null;
                    }
                }
                if(scp457a == true)
                {
                    scp457sh = 0;
                    foreach (Inventory.SyncItemInfo syncItemInfo in scp457.GetAllItems())
                    {
                        if (syncItemInfo.id.IsSCP())
                        {
                            scp457sh++;

                        }
                    }
                    scp457.Broadcast(5, "<color=red>[SCP457]</color>\n<color=lime>灼烧等级:</color>" + scp457sh, false);
                }
                yield return Timing.WaitForSeconds(10f);
            }

        }


        private IEnumerator<float> SecondCounter22()
        {
            for (; ; )
            {
                if (scp457a == true)
                {
                    if(scp457.GetRole() == RoleType.Tutorial)
                    {
                        scp457b = scp457.GetPosition();
                        float num2 = scp457b.x + 4;
                        float num3 = scp457b.y + 4;
                        float num4 = scp457b.z + 4;
                        float num5 = scp457b.x - 4;
                        float num6 = scp457b.y - 4;
                        float num7 = scp457b.z - 4;

                        foreach (ReferenceHub player in Player.GetHubs())
                        {
                            if ((player.GetTeam() != Team.SCP) && (player.GetPlayerId() != scp457id) && (player.GetPosition().x <= num2) && (player.GetPosition().x >= num5) && (player.GetPosition().y <= num3) && (player.GetPosition().y >= num6) && (player.GetPosition().z <= num4) && (player.GetPosition().z >= num7))
                            {
                                int sh = 4 + 2 * scp457sh;
                                player.AddHealth(-sh);
                                player.Broadcast(1, "<color=red>[你感到自己火了]</color>", false);
                                

                                
                            }
                        }

                    }

                }

                yield return Timing.WaitForSeconds(1f);
            }

        }


        private IEnumerator<float> SecondCounter21()
        {
            for (; ; )
            {
                if(starttimer ==true)
                {
                    yield return Timing.WaitForSeconds(1800f);
                    Map.StartNuke();
                    xitonghedan = true;
                    Map.Broadcast("<color=red>[警告]</color>\n<color=lime>系统核弹已开启无法关闭</color>", 5,  false);

                }
                yield return Timing.WaitForSeconds(5f);

            }

        }

        public void  Setrank_new(String text, String color, ReferenceHub player) {
            player.serverRoles.NetworkMyText = text;
            player.serverRoles.NetworkMyColor = color;
        }
        
        
        public IEnumerator<float> CheckFor939Intercom()
        {
            for (; ; )
            {
                yield return Timing.WaitForSeconds(0.1f);

                if (Intercom.host.speaker != null || Intercom.host.speaking)
                    continue;
                foreach (ReferenceHub rh in Player.GetHubs())
                {
                    try
                    {
                        //Plugin.Info("Checking class");
                        if (!rh.characterClassManager.CurClass.Is939())
                            continue;
                        //Plugin.Info("Is939");
                        GameObject player = rh.gameObject;
                        //Plugin.Info("got game object");
                        Intercom intercom = player.GetComponent<Intercom>();
                        //Plugin.Info("Got intercom");
                        Scp939PlayerScript script = player.GetComponent<Scp939PlayerScript>();
                        //Plugin.Info("Got script");

                        if (Vector3.Distance(player.transform.position, IntercomArea.position) >
                            intercom.triggerDistance)
                        {
                            //Plugin.Info("distance check too far");
                            continue;
                        }

                        if (!script.NetworkusingHumanChat)
                        {
                            //Plugin.Info("not using hooman chat");
                            continue;
                        }

                        //Plugin.Info("requesting transmition");
                        Intercom.host.RequestTransmission(player);
                    }
                    catch (Exception e)
                    {
                        while (e != null)
                        {
                            Log.Error(e.ToString());
                            e = e.InnerException;
                        }
                    }
                }
            }
        }
        private IEnumerator<float> Scp2006coin()
        {
            yield return Timing.WaitForSeconds(10f);
            scp2006.AddItem(ItemType.Coin);
            scp2006.AddItem(ItemType.Coin);
            scp2006.AddItem(ItemType.Coin);
            scp2006.AddItem(ItemType.Coin);
            scp2006.AddItem(ItemType.Coin);
            scp2006.AddItem(ItemType.Coin);
            scp2006.AddItem(ItemType.Coin);
            scp2006.AddItem(ItemType.Coin);
        }
        private IEnumerator<float> SecondCounter20()
        {
            for (; ; )
            {
                yield return Timing.WaitForSeconds(10f);

                if ((starttimer == true) &&(diyicizhixingzheli ==true))
                {
                    yield return Timing.WaitForSeconds(8f);
                    if (card == 1)
                    {
                        scp181.AddItem(ItemType.KeycardChaosInsurgency);
                        card = 0;
                        scp181.AddItem(ItemType.Coin);
                    }
                    if (card == 2)
                    {
                        scp181.AddItem(ItemType.KeycardContainmentEngineer);
                        card = 0;
                        scp181.AddItem(ItemType.Coin);
                        
                    }
                    if (card == 4)
                    {
                        scp181.AddItem(ItemType.KeycardJanitor);
                        card = 0;
                        scp181.AddItem(ItemType.Coin);

                    }
                    if (card == 5)
                    {
                        scp181.AddItem(ItemType.KeycardScientistMajor);
                        card = 0;
                        scp181.AddItem(ItemType.Coin);

                    }
                    if (card == 6)
                    {
                        scp181.AddItem(ItemType.KeycardNTFCommander);
                        card = 0;
                        scp181.AddItem(ItemType.Coin);
                        
                    }
                    if (card == 7)
                    {
                        scp181.AddItem(ItemType.KeycardNTFLieutenant);
                        card = 0;
                        scp181.AddItem(ItemType.Coin);

                    }
                    if (card == 8)
                    {
                        scp181.AddItem(ItemType.KeycardO5);
                        card = 0;
                        scp181.AddItem(ItemType.Coin);

                    }
                    if (card == 9)
                    {
                        scp181.AddItem(ItemType.KeycardScientist);
                        card = 0;
                        scp181.AddItem(ItemType.Coin);
                    }
                    if (card == 10)
                    {
                        scp181.AddItem(ItemType.KeycardZoneManager);
                        card = 0;
                        scp181.AddItem(ItemType.Coin);

                    }
                    if (scp035item2 == true)
                    {
                        Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(scp035, 300)));

                        scp035.AddItem(ItemType.GunUSP);
                        scp035.AddItem(ItemType.Ammo9mm);
                        scp035.AddItem(ItemType.Ammo9mm);
                        scp035.AddItem(ItemType.Ammo9mm);
                        scp035.AddItem(ItemType.KeycardScientist);
                        scp035item2 = false;
                        foreach (GameObject door in GameObject.FindGameObjectsWithTag("Door"))
                        {
                            if (door.name == "173_ARMORY")
                            {
                                scp035.SetPosition(door.transform.position.x, door.transform.position.y + (float)1.5, door.transform.position.z);
                            }
                        }

                    }

                    if (d9341flash == true)
                    {
                        D9341.AddItem(ItemType.Flashlight);
                        D9341.AddItem(ItemType.GrenadeFlash);
                        d9341flash = false;
                    }
                    if (cxkflash == true)
                    {
                        cxk.AddItem(ItemType.Flashlight);
                        cxkflash = false;
                    }
                    if (scp035health == true)
                    {
                        Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(scp035, 500)));
                        scp035health = false;
                    }
                    if (scp076iteam == true)
                    {
                        scp076.SetRole(RoleType.NtfCommander);
                        Coroutines.Add(Timing.RunCoroutine(SecondCounter10()));
                    }
                    foreach (ReferenceHub referenceHub in Player.GetHubs())
                    {
                        if(referenceHub.GetRole() == RoleType.Scp93953)
                        {
                            referenceHub.SetHealth(6000);
                        }
                        if (referenceHub.GetRole() == RoleType.Scp93989)
                        {
                            referenceHub.SetHealth(6000);
                        }
                        if (referenceHub.GetRole() == RoleType.Scp049)
                        {
                            referenceHub.SetHealth(3500);
                        }
                        if (referenceHub.GetRole() == RoleType.Scp173)
                        {
                            referenceHub.SetHealth(4200);
                        }
                        if (referenceHub.GetRole() == RoleType.Scp096)
                        {
                            referenceHub.SetHealth(1500);
                        }
                        if(referenceHub.GetRole() == RoleType.ClassD)
                        {
                            referenceHub.SetHealth(100);
                        }
                        if(referenceHub.GetRole() == RoleType.FacilityGuard)
                        {
                            referenceHub.SetHealth(100);
                        }
                        if(referenceHub.GetRole() == RoleType.Scientist)
                        {
                            referenceHub.SetHealth(120);
                        }
                    }
                    diyicizhixingzheli = false;
                }


            }

        }
        private IEnumerator<float> Wdzs()
        {
            yield return Timing.WaitForSeconds(10f);
            
            foreach (ReferenceHub player3 in Player.GetHubs())
            {
                if (player3.GetRole() == RoleType.Scp173)
                {
                    if(player3.GetPlayerId()!= scp650id)
                    {
                        player3.SetHealth(4200);
                        player3.SetGodMode(false);
                    }
                }
                if(player3.GetHealth()>=10000)
                {
                    player3.SetHealth(10000);
                }
            }
            xhsnb = false;
        }
        private IEnumerator<float> SecondCounter19()
        {
            for (; ; )
            {
                if(scp035goout == true)
                {

                    Setrank_new("SCP-035", "red", scp035);
                    Map.Broadcast("<color=red>因为SCP-035逃出设施 每150s会随机死亡一个玩家</color>", 10, false);
                    yield return Timing.WaitForSeconds(150f);
                    foreach(ReferenceHub referenceHub in Player.GetHubs())
                    {
                        referenceHub.Kill();
                        referenceHub.SetRole(RoleType.Spectator);
                        break;
                    }
                }
                yield return Timing.WaitForSeconds(1f);

            }

        }      
        private IEnumerator<float> SecondCounter18()
        {
            for (; ; )
            {
                if (roundstart == true)
                {
                    yield return Timing.WaitForSeconds(100f);
                    foreach(ReferenceHub referenceHub in Player.GetHubs())
                    {
                        if(referenceHub.GetHealth() >= 10000)
                        {
                            referenceHub.SetHealth(10000);
                        }
                    }
                    if(choise == false)
                    {
                        choise = true;
                        foreach (ReferenceHub p in Player.GetHubs())
                        {
                            if (p.GetRole() == RoleType.Scp079)
                            {
                                p.serverRoles.NetworkMyText = "SCP079 - 帮助SCP";
                                p.serverRoles.NetworkMyColor = "aqua";

                            }
                        }
                        Map.Broadcast("<color=#FFC0CB>---[SCP079]---</color>\n<color=aqua>人类感受恐惧吧 本局SCP079选择帮助SCP</color>\n<color=aqua>SCP不会受到电网的伤害</color>", 10, false);
                    }

                }
                yield return Timing.WaitForSeconds(1f);

            }
        }
        private IEnumerator<float> SecondCounter17()
        {
            for (; ; )
            {
                if (times5 == 6)
                {
                    foreach (ReferenceHub player in Player.GetHubs())
                    {
                        if (player.GetUserId() == "76561198197721054@steam")
                        {
                            Setrank_new("求别乱杀DD", "yellow", player);
                        }
                        if (player.GetUserId() == "76561198441344563@steam")
                        {
                            Setrank_new("服内最帅大佬", "yellow", player);
                        }
                        if (player.GetUserId() == "76561198816705835@steam")
                        {
                            Setrank_new("孤独一生", "lime", player);
                        }
                        if (player.GetUserId() == "76561198369468432@steam")
                        {
                            Setrank_new("白嫖大法好", "yellow", player);
                        }
                        if (player.GetUserId() == "76561198997348090@steam")
                        {
                            Setrank_new("因为是魔王所以很棒呀", "yellow", player);
                        }
                        if (player.GetUserId() == "76561198893112896@steam")
                        {
                            Setrank_new("迪奥·布兰度", "cyan", player);
                        }
                        if (player.GetUserId() == "76561198377975833@steam")
                        {
                            Setrank_new("02は世界で一番いいです", "cyan", player);
                        }
                        if (player.GetUserId() == "76561198385564103@steam")
                        {
                            Setrank_new("半仙", "cyan", player);
                        }
                    }
                    times5 = 1;
                }
                if (times5 == 5)
                {
                    foreach (ReferenceHub player in Player.GetHubs())

                    {
                        if (player.GetUserId() == "76561198197721054@steam")
                        {
                            Setrank_new("求别乱杀DD", "green", player);
                        }
                        if (player.GetUserId() == "76561198441344563@steam")
                        {
                            Setrank_new("服内最帅大佬", "green", player);
                        }
                        if (player.GetUserId() == "76561198816705835@steam")
                        {
                            Setrank_new("孤独一生", "crimson", player);
                        }
                        if (player.GetUserId() == "76561198369468432@steam")
                        {
                            Setrank_new("白嫖大法好", "green", player);
                        }
                        if (player.GetUserId() == "76561198997348090@steam")
                        {
                            Setrank_new("因为是魔王所以很棒呀", "green", player);
                        }
                        if (player.GetUserId() == "76561198893112896@steam")
                        {
                            Setrank_new("迪奥·布兰度", "green", player);
                        }
                        if (player.GetUserId() == "76561198377975833@steam")
                        {
                            Setrank_new("02は世界で一番いいです", "green", player);
                        }
                        if (player.GetUserId() == "76561198385564103@steam")
                        {
                            Setrank_new("半仙", "green", player);
                        }
                    }
                    times5 = 6;
                }
                if (times5 == 4)
                {
                    foreach (ReferenceHub player in Player.GetHubs())

                    {
                        if (player.GetUserId() == "76561198197721054@steam")
                        {
                            Setrank_new("求别乱杀DD", "red", player);
                        }
                        if (player.GetUserId() == "76561198441344563@steam")
                        {
                            Setrank_new("服内最帅大佬", "red", player);
                        }
                        if (player.GetUserId() == "76561198816705835@steam")
                        {
                            Setrank_new("孤独一生", "cyan", player);
                        }
                        if (player.GetUserId() == "76561198369468432@steam")
                        {
                            Setrank_new("白嫖大法好", "red", player);
                        }
                        if (player.GetUserId() == "76561198997348090@steam")
                        {
                            Setrank_new("因为是魔王所以很棒呀", "red", player);
                        }
                        if (player.GetUserId() == "76561198893112896@steam")
                        {
                            Setrank_new("迪奥·布兰度", "red", player);
                        }
                        if (player.GetUserId() == "76561198377975833@steam")
                        {
                            Setrank_new("02は世界で一番いいです", "red", player);
                        }
                        if (player.GetUserId() == "76561198385564103@steam")
                        {
                            Setrank_new("半仙", "red", player);
                        }
                    }
                    times5 = 5;
                }
                if (times5 == 3)
                {
                    foreach (ReferenceHub player in Player.GetHubs())

                    {
                        if (player.GetUserId() == "76561198197721054@steam")
                        {
                            Setrank_new("求别乱杀DD", "cyan", player);
                        }
                        if (player.GetUserId() == "76561198441344563@steam")
                        {
                            Setrank_new("服内最帅大佬", "cyan", player);
                        }
                        if (player.GetUserId() == "76561198816705835@steam")
                        {
                            Setrank_new("孤独一生", "red", player);
                        }
                        if (player.GetUserId() == "76561198369468432@steam")
                        {
                            Setrank_new("白嫖大法好", "cyan", player);
                        }
                        if (player.GetUserId() == "76561198997348090@steam")
                        {
                            Setrank_new("因为是魔王所以很棒呀", "cyan", player);
                        }
                        if (player.GetUserId() == "76561198893112896@steam")
                        {
                            Setrank_new("迪奥·布兰度", "pink", player);
                        }
                        if (player.GetUserId() == "76561198377975833@steam")
                        {
                            Setrank_new("02は世界で一番いいです", "pink", player);
                        }
                        if (player.GetUserId() == "76561198385564103@steam")
                        {
                            Setrank_new("半仙", "pink", player);
                        }
                    }
                    times5 = 4;
                }
                if (times5 == 2)
                {
                    foreach (ReferenceHub player in Player.GetHubs())

                    {
                        if (player.GetUserId() == "76561198197721054@steam")
                        {
                            Setrank_new("求别乱杀DD", "crimson", player);
                        }
                        if (player.GetUserId() == "76561198441344563@steam")
                        {
                            Setrank_new("服内最帅大佬", "crimson", player);
                        }
                        if (player.GetUserId() == "76561198816705835@steam")
                        {
                            Setrank_new("孤独一生", "green", player);
                        }
                        if (player.GetUserId() == "76561198369468432@steam")
                        {
                            Setrank_new("白嫖大法好", "crimson", player);
                        }
                        if (player.GetUserId() == "76561198997348090@steam")
                        {
                            Setrank_new("因为是魔王所以很棒呀", "crimson", player);
                        }
                        if (player.GetUserId() == "76561198893112896@steam")
                        {
                            Setrank_new("迪奥·布兰度", "orange", player);
                        }
                        if (player.GetUserId() == "76561198377975833@steam")
                        {
                            Setrank_new("02は世界で一番いいです", "orange", player);
                        }
                        if (player.GetUserId() == "76561198385564103@steam")
                        {
                            Setrank_new("半仙", "orange", player);
                        }
                    }
                    times5 = 3;
                }
                if (times5 == 1)
                {
                    foreach (ReferenceHub player in Player.GetHubs())

                    {
                        if (player.GetUserId() == "76561198197721054@steam")
                        {
                            Setrank_new("求别乱杀DD", "lime", player);
                        }
                        if (player.GetUserId() == "76561198441344563@steam")
                        {
                            Setrank_new("服内最帅大佬", "lime", player);
                        }
                        if (player.GetUserId() == "76561198816705835@steam")
                        {
                            Setrank_new("孤独一生", "yellow", player);
                        }
                        if (player.GetUserId() == "76561198369468432@steam")
                        {
                            Setrank_new("白嫖大法好", "lime", player);
                        }
                        if (player.GetUserId() == "76561198997348090@steam")
                        {
                            Setrank_new("因为是魔王所以很棒呀", "lime", player);
                        }
                        if (player.GetUserId() == "76561198893112896@steam")
                        {
                            Setrank_new("迪奥·布兰度", "yellow", player);
                        }
                        if (player.GetUserId() == "76561198377975833@steam")
                        {
                            Setrank_new("02は世界で一番いいです", "yellow", player);
                        }
                        if (player.GetUserId() == "76561198385564103@steam")
                        {
                            Setrank_new("半仙", "yellow", player);
                        }
                    }
                    times5 = 2;
                }
                yield return Timing.WaitForSeconds(6f);
            }
        }
        private IEnumerator<float> SecondCounter16()
        {
            for (; ; )
            {
                foreach(ReferenceHub hub in Player.GetHubs())
                {
                    if(hub.GetRole() != RoleType.Scp173)
                    {
                        hub.SetGodMode(false);
                    }

                }
                bscd = false;
                yield return Timing.WaitForSeconds(10f);
            }
        }
        private IEnumerator<float> SecondCounter14()
        {
            for (; ; )
            {
                if (ylb1 == true)
                {
                    Vector3 pos2 = ylb.GetPosition();
                    float num2 = pos2.x + 3;
                    float num3 = pos2.y + 3;
                    float num4 = pos2.z + 3;
                    float num5 = pos2.x - 3;
                    float num6 = pos2.y - 3;
                    float num7 = pos2.z - 3;

                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        if ((player3.GetTeam() == Team.MTF) && (player3.GetPosition().x <= num2) && (player3.GetPosition().x >= num5) && (player3.GetPosition().y <= num3) && (player3.GetPosition().y >= num6) && ((player3.GetPosition().z <= num4) && (player3.GetPosition().z >= num7)))
                        {
                            player3.AddHealth(1);
                            player3.Broadcast(5, "<color=yellow>[九尾狐医疗兵]</color>\n<color=#00FFFF>我正在治疗你的伤势</color>", false);
                        }
                    }

                }
                if (lv == 1)
                {
                    foreach (ReferenceHub player3 in Player.GetHubs())

                    {
                        if (player3.GetRole() == RoleType.Scp049)
                        {
                            player3.AddHealth(5);
                        }
                    }
                }
                if (lv == 2)
                {
                    ;
                    foreach (ReferenceHub player3 in Player.GetHubs())
                    {
                        if (player3.GetRole() == RoleType.Scp049)
                        {
                            player3.AddHealth(10);
                        }
                    }
                }
                if (lv == 3)
                {
                    foreach (ReferenceHub player3 in Player.GetHubs())

                    {
                        if (player3.GetRole() == RoleType.Scp049)
                        {
                            player3.AddHealth(15);
                        }
                    }
                }

                if(scp49jyes == true)
                {
                    foreach(ReferenceHub referenceHub in Player.GetHubs())
                    {
                        if(referenceHub.GetRole() == RoleType.FacilityGuard && scp_999.Contains(referenceHub.GetUserId()) == false)
                        {
                            scp49j = referenceHub;
                            scp49jid = referenceHub.GetPlayerId();
                            break;
                        }
                    }
                }
                yield return Timing.WaitForSeconds(5f);

            }
        }
        private IEnumerator<float> SecondCounter3()
        {
            for (; ; )
            {
                if (sjtz1 == true)
                {
                    foreach (ReferenceHub referenceHub in Player.GetHubs())
                    {
                        if(Dio2.Contains(referenceHub.GetUserId())==false)
                        {
                            referenceHub.SetPosition(referenceHub.GetPosition());
                        }
                    }
                    //for (int i = 0; i < playerdio.Count; i++)
                    //{
                      //  if (Dio2.Contains(playerdio[i].GetUserId()) == false)
                        //{
                          //  playerdio[i].SetPosition(pos1[i]);
                        //}
                   // }
                }
                if (qblcq2 == true)
                {
                    qblcq.SetPosition(scpqbl3.GetPosition());
                }
                if(ljfuse == true)
                {
                    foreach(ReferenceHub referenceHub in ljfwj)
                    {
                        if(referenceHub.GetPlayerId() != fkyyzid)
                        {
                            referenceHub.SetPosition(referenceHub.GetPosition());

                        }
                    }
                }
                if(jzsjuse == true)
                {
                    foreach (ReferenceHub referenceHub in Player.GetHubs())
                    {
                        if (referenceHub.GetPlayerId() != fkyyzid)
                        {
                            referenceHub.SetPosition(referenceHub.GetPosition());

                        }
                    }

                }
                
                yield return Timing.WaitForSeconds(0.2f);
            }
        }

        private IEnumerator<float> SecondCounter12()
        {
            for (; ; )
            {
                if (cxkyes == true)
                {
                    yield return Timing.WaitForSeconds(100f);
                    cxk.AddItem(ItemType.Flashlight);
                    cxk.Broadcast(4, "<color=#00FF00>你感受到 一段音乐在你脑中想起\n你突然感觉鸡很美丽</color>", false);
                }
                

                yield return Timing.WaitForSeconds(1f);
            }
        }
        private IEnumerator<float> SecondCounter13()
        {
            for (; ; )
            {
                if(scp817yes == true)
                {
                    yield return Timing.WaitForSeconds(150f);
                    pos3 = scp817.GetPosition();

                    int Rolenum = new System.Random().Next(1, 14);
                    if (Rolenum == 1)
                    {
                        scp817.SetRole(RoleType.Scientist, true);
                    }
                    if (Rolenum == 2)
                    {
                        scp817.SetRole(RoleType.ChaosInsurgency, true);
                    }
                    if (Rolenum == 3)
                    {
                        scp817.SetRole(RoleType.FacilityGuard, true);
                    }
                    if (Rolenum == 4)
                    {
                        scp817.SetRole(RoleType.NtfCadet, true);
                    }
                    if (Rolenum == 5)
                    {
                        scp817.SetRole(RoleType.NtfCommander, true);
                    }
                    if (Rolenum == 6)
                    {
                        scp817.SetRole(RoleType.NtfLieutenant, true);
                    }
                    if (Rolenum == 7)
                    {
                        scp817.SetRole(RoleType.NtfScientist, true);
                    }
                    if (Rolenum == 8)
                    {
                        scp817.SetRole(RoleType.Scp079, true);
                    }
                    if (Rolenum == 9)
                    {
                        scp817.SetRole(RoleType.Scp106, true);
                    }
                    if (Rolenum == 10)
                    {
                        scp817.SetRole(RoleType.Scp173, true);
                    }
                    if (Rolenum == 11)
                    {
                        scp817.SetRole(RoleType.Scp93953, true);
                    }
                    if (Rolenum == 12)
                    {
                        scp817.SetRole(RoleType.Scp93989, true);
                    }
                    if (Rolenum == 13)
                    {
                        scp817.SetRole(RoleType.Tutorial,true);
                    }

                    scp817.Broadcast(5, "<color=red>[个人通知]</color>\n<color=#FFFF00>恭喜你性转成功 你已经是女孩子了</color>", false);
                    times3 = 1;
                    scp817.SetPosition(pos3);
                }
                yield return Timing.WaitForSeconds(10f);
            }
        }
        //九尾狐飞机主方法
        public IEnumerator<float> ChopperThread()
        {
            while (roundstart)
            {
                // Unity GARBAGE
                Log.Info("九尾狐物资刷新延时10min.");
                yield return Timing.WaitForSeconds(600); // 等待10分钟
                Log.Info("刷新物资!");
                foreach(ReferenceHub referenceHub in Player.GetHubs()){
                    if(referenceHub.GetHealth() > 8000)
                    {
                        referenceHub.SetHealth(8000);
                    }
                }
                foreach (ReferenceHub h in Player.GetHubs()) // 九尾狐
                    h.Broadcast(5, "<color=66FF00>[九尾狐电台]</color>\n<color=#00FFFF>一份九尾狐补给正在通过飞机送达</color>",false);

                yield return Timing.WaitForSeconds(15); // Wait 15 seconds
                Vector3 spawn = Map.GetRandomSpawnPoint(RoleType.NtfCadet); //获取补给刷新位置
                Map.SpawnItem(ItemType.Ammo556, 1000, spawn);
                Map.SpawnItem(ItemType.Ammo556, 1000, spawn);
                Map.SpawnItem(ItemType.Ammo556, 1000, spawn);
                Map.SpawnItem(ItemType.Ammo556, 1000, spawn);
                Map.SpawnItem(ItemType.Ammo762, 1000, spawn);
                Map.SpawnItem(ItemType.Ammo762, 1000, spawn);
                Map.SpawnItem(ItemType.Ammo762, 1000, spawn);
                Map.SpawnItem(ItemType.Ammo762, 1000, spawn);
                Map.SpawnItem(ItemType.Ammo9mm, 1000, spawn);
                Map.SpawnItem(ItemType.Ammo9mm, 1000, spawn);
                Map.SpawnItem(ItemType.Ammo9mm, 1000, spawn);
                Map.SpawnItem(ItemType.SCP500, 1000, spawn);
                Map.SpawnItem(ItemType.Medkit, 1000, spawn);
                Map.SpawnItem(ItemType.GunLogicer, 1000, spawn);
                Map.SpawnItem(ItemType.Adrenaline, 1000, spawn);
                Map.SpawnItem(ItemType.Flashlight, 1000, spawn);
                Map.SpawnItem(ItemType.GrenadeFlash, 1000, spawn);
                Map.SpawnItem(ItemType.GrenadeFlash, 1000, spawn);
                Map.SpawnItem(ItemType.GrenadeFlash, 1000, spawn);

                yield return Timing.WaitForSeconds(15); // 飞机离开
            }
        }
        private IEnumerator<float> SecondCounter11()
        {
            for (; ; )
            {
                if(jntm == true)
                {
                    yield return Timing.WaitForSeconds(10f);
                    jntm = false;
                }
                yield return Timing.WaitForSeconds(1f);
            }
        }
        private IEnumerator<float> SecondCounter10()
        {
            for (; ; )
            {
                yield return Timing.WaitForSeconds(0.5f);

                if (scp076iteam == true)
                {
                    foreach (Inventory.SyncItemInfo syncItemInfo in scp076.GetAllItems())
                    {
                        scp076.RemoveItem(syncItemInfo);
                    }
                    scp076.AddItem(ItemType.GunE11SR);
                    scp076.AddItem(ItemType.Radio);
                    scp076.AddItem(ItemType.Adrenaline);
                    scp076.AddItem(ItemType.GrenadeFrag);
                    scp076.AddItem(ItemType.GrenadeFrag);
                    scp076.AddItem(ItemType.MicroHID);
                    scp076iteam = false;
                }
                scp076.AddItem(ItemType.MicroHID);
                yield return Timing.WaitForSeconds(240f);
            }
        }
        private IEnumerator<float> SecondCounter9()
        {
            for (; ; )
            {
                if (scp3108shotyes == true)
                {
                    scp3108playerid = 0;
                }
                scp2006.AddItem(ItemType.Coin);
                foreach (ReferenceHub player in Player.GetHubs())
                {
                    if (player.GetTeam() == Team.SCP)
                    {
                        player.AddHealth(25);
                    }
                }
                if (bpb == true)
                {
                    foreach (ReferenceHub player in Player.GetHubs())
                    {
                        if (bpb2.Contains(player.GetPlayerId()))
                        {
                            player.AddItem(ItemType.GrenadeFrag);
                        }
                    }
                }
                if (ylb1 == true)
                {
                    ylb.AddItem(ItemType.Medkit);
                }
                yield return Timing.WaitForSeconds(100f);
            }
        }
        private IEnumerator<float> SecondCounter7()
        {
            for (; ; )
            {
                if(starttimer == true)
                {
                    Map.Broadcast("<color=#FFFF00>[小鱼服务器清理大师]</color>\n<color=#66FFFF>哇你们白给了好多垃圾成堆了呀</color>\n我会在<color=red>600s</color>后清理服务器", 10, false);
                    yield return Timing.WaitForSeconds(200f);
                    Map.Broadcast("<color=#FFFF00>[小鱼服务器清理大师]</color>\n<color=#66FFFF>哇你们白给了好多垃圾成堆了呀</color>\n我会在<color=red>400s</color>后清理服务器", 10, false);
                    yield return Timing.WaitForSeconds(200f);
                    Map.Broadcast("<color=#FFFF00>[小鱼服务器清理大师]</color>\n<color=#66FFFF>哇你们白给了好多垃圾成堆了呀</color>\n我会在<color=red>200s</color>后清理服务器", 10, false);
                    yield return Timing.WaitForSeconds(150f);
                    Map.Broadcast("<color=#FFFF00>[小鱼服务器清理大师]</color>\n<color=#66FFFF>哇你们白给了好多垃圾成堆了呀</color>\n我会在<color=red>50s</color>后清理服务器", 10, false);
                    yield return Timing.WaitForSeconds(40f);
                    Map.Broadcast("<color=#FFFF00>[小鱼服务器清理大师]</color>\n<color=#66FFFF>哇你们白给了好多垃圾成堆了呀</color>\n我会在<color=red>10s</color>后清理服务器", 5, false);
                    yield return Timing.WaitForSeconds(5f);
                    Map.Broadcast("<color=#FFFF00>[小鱼服务器清理大师]</color>\n<color=#66FFFF>哇你们白给了好多垃圾成堆了呀</color>\n我会在<color=red>5s</color>后清理服务器", 1, false);
                    yield return Timing.WaitForSeconds(1f);
                    Map.Broadcast("<color=#FFFF00>[小鱼服务器清理大师]</color>\n<color=#66FFFF>哇你们白给了好多垃圾成堆了呀</color>\n我会在<color=red>4s</color>后清理服务器", 1, false);
                    yield return Timing.WaitForSeconds(1f);
                    Map.Broadcast("<color=#FFFF00>[小鱼服务器清理大师]</color>\n<color=#66FFFF>哇你们白给了好多垃圾成堆了呀</color>\n我会在<color=red>3s</color>后清理服务器", 1, false);
                    yield return Timing.WaitForSeconds(1f);
                    Map.Broadcast("<color=#FFFF00>[小鱼服务器清理大师]</color>\n<color=#66FFFF>哇你们白给了好多垃圾成堆了呀</color>\n我会在<color=red>2s</color>后清理服务器", 1, false);
                    yield return Timing.WaitForSeconds(1f);
                    Map.Broadcast("<color=#FFFF00>[小鱼服务器清理大师]</color>\n<color=#66FFFF>哇你们白给了好多垃圾成堆了呀</color>\n我会在<color=red>1s</color>后清理服务器", 1, false);
                    yield return Timing.WaitForSeconds(1f);
                    Map.Broadcast("<color=#FFFF00>[小鱼服务器清理大师]</color>\n<color=#66FFFF>开始清理</color>", 4, false);
                    foreach (Ragdoll ragdoll in UnityEngine.Object.FindObjectsOfType<Ragdoll>())
                    {
                        NetworkServer.Destroy(ragdoll.gameObject);
                        ragdolltime++;
                    }
                    foreach (Pickup item in UnityEngine.Object.FindObjectsOfType<Pickup>())
                    {
                        if (item.ItemId == ItemType.Ammo556 || item.ItemId == ItemType.Ammo762 || item.ItemId == ItemType.Ammo9mm || item.ItemId == ItemType.GunE11SR || item.ItemId == ItemType.WeaponManagerTablet || item.ItemId == ItemType.GrenadeFlash || item.ItemId == ItemType.GrenadeFrag || item.ItemId == ItemType.Disarmer || item.ItemId == ItemType.GunLogicer || item.ItemId == ItemType.GunProject90 || item.ItemId == ItemType.Radio)
                        {
                            item.Delete();
                            itemtime++;
                        }

                    }
                    Map.Broadcast("<color=#FFFF00>[小鱼服务器清理大师]</color>\n<color=#66FFFF>好饱呀</color>\n本次清理了" + itemtime.ToString() + "个物品" + ragdolltime.ToString() + "个尸体", 4, false);
                    itemtime = 0;
                    ragdolltime = 0;
                    yield return Timing.WaitForSeconds(100f);

                }
                yield return Timing.WaitForSeconds(1f);

            }
        }
        private IEnumerator<float> Diotp()
        {
            yield return Timing.WaitForSeconds(1f);
            Dio.SetPosition(Map.GetRandomSpawnPoint(RoleType.ChaosInsurgency));
            yield return Timing.WaitForSeconds(0.5f);
            Dio.SetPosition(Map.GetRandomSpawnPoint(RoleType.ChaosInsurgency));
        }
        private IEnumerator<float> Scp457tp()
        {
            yield return Timing.WaitForSeconds(1f);
            scp457.SetPosition(Map.GetRandomSpawnPoint(RoleType.Scp096));
            yield return Timing.WaitForSeconds(0.5f);
            scp457.SetPosition(Map.GetRandomSpawnPoint(RoleType.Scp096));
        }
        
        private IEnumerator<float> SecondCounter6()
        {
            for (; ; )
            {
                //1143给手榴弹
                //混沌指挥官分配
                if (scp073zb == false)
                {
                    yield return Timing.WaitForSeconds(2f);
                    scp073.SetRole(RoleType.NtfLieutenant);
                    scp073zb = true;
                    Log.Info("测试4");

                }
                if (jljyzb == true)
                {
                    yield return Timing.WaitForSeconds(2f);

                    jljy.SetRole(RoleType.Tutorial);
                    jljy.SetPosition(Map.GetRandomSpawnPoint(RoleType.FacilityGuard));
                    jljy.AddItem(ItemType.GunE11SR);
                    jljy.AddItem(ItemType.MicroHID);
                    jljy.AddItem(ItemType.MicroHID);
                    jljy.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped5, 400);
                    jljy.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped7, 400);
                    jljy.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped9, 400);
                    jljy.AddItem(ItemType.KeycardNTFCommander);
                    Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(jljy, 250)));
                    
                    jljy2.Add(jljy.GetUserId());
                    Setrank_new("吉良吉影", "red", jljy);
                    jljyzb = false;
                    Log.Info("测试6");

                }
                if (scp999tp == true)
                {
                    scp999tp = false;
                    scp.SetPosition(Map.GetRandomSpawnPoint(RoleType.FacilityGuard));
                    yield return Timing.WaitForSeconds(2f);
                    scp.SetPosition(Map.GetRandomSpawnPoint(RoleType.FacilityGuard));
                    scp.SetGodMode(false);
                }
                yield return Timing.WaitForSeconds(10f);
            }
        }
        private IEnumerator<float> Scp550item()
        {
            yield return Timing.WaitForSeconds(2f);

            Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(scp550, 5000)));

            Setrank_new("SCP-550", "red", scp550);
            meitunshi = true;
            scp550.Broadcast(10, "<color=lime>[SCP550]</color>\n<color=yello>你是食尸鬼:HP:5000 如果30s内没吞噬尸体每秒损失8HP</color>\n<color=yellow>站在尸体边上即可吞噬尸体 吞噬完成后你会获得能力的提升</color>", false);
            Coroutines.Add(Timing.RunCoroutine(SecondCounter26()));
            scp550.AddItem(ItemType.GunProject90);
            scp550.SetPosition(Map.GetRandomSpawnPoint(RoleType.Scp049));
        }
        private IEnumerator<float> Hhzhgzb()
        {
            yield return Timing.WaitForSeconds(2f);
            HDZHG.ClearBroadcasts();
            HDZHG.Broadcast(5, "<color=yellow>[个人通知]</color>\n<color=lime>你是</color><color=#00FFFF>[混沌指挥官]</color><color=lime>请带领着混沌走向胜利\n输入.help查看技能</color>", false);
            Setrank_new("混沌指挥官", "yello", HDZHG);
            Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(HDZHG, 150)));
            HDZHG.AddItem(ItemType.KeycardO5);
            HDZHG2.Add(HDZHG.GetUserId());
        }
        private IEnumerator<float> Mzzb()
        {
            yield return Timing.WaitForSeconds(2f);

            Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(mz, 500)));

            mz.AddItem(ItemType.SCP500);
            mz.AddItem(ItemType.Adrenaline);
            Setrank_new("毛子", "white", mz);
            Map.Broadcast("Сука блядь 乌拉  бутылка водки", 5, false);
            Log.Info("测试2");
        }
        private IEnumerator<float> Mrfishzb()
        {
            yield return Timing.WaitForSeconds(2f);
            mrfish.SetRole(RoleType.Scientist, true);
            yield return Timing.WaitForSeconds(2f);
            mrfish.SetHealth(120);
            mrfish.AddItem(ItemType.KeycardO5);
            mrfish.AddItem(ItemType.MicroHID);
            mrfish.AddItem(ItemType.GunLogicer);
            mrfish.AddItem(ItemType.GrenadeFrag);
            mrfish.AddItem(ItemType.Radio);
            mrfish.AddItem(ItemType.SCP500);
            mrfish.AddItem(ItemType.SCP207);
            mrfish.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped5, 400);
            mrfish.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped7, 400);
            mrfish.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped9, 400);
            Log.Info("测试5");
        }

        private IEnumerator<float> Scp1577bj()
        {
            yield return Timing.WaitForSeconds(2f);
            Vector3 vector3 = new Vector3(scp1577pos.x, scp1577pos.y + 1, scp1577pos.z);
            Map.SpawnItem(ItemType.SCP500, 500, vector3);
            Map.SpawnItem(ItemType.SCP500, 500, vector3);
            Map.SpawnItem(ItemType.Medkit, 500, vector3);
            Map.SpawnItem(ItemType.MicroHID, 500, vector3);
            Map.SpawnItem(ItemType.KeycardO5, 500, vector3);
            Log.Info("测试7");
        }

        private IEnumerator<float> Giveboom()
        {
            for (; ; )
            {
                yield return Timing.WaitForSeconds(40f);
                if (scp1143a == true)
                {
                    scp1143.AddItem(ItemType.GrenadeFrag);
                }
            }

        }

        private IEnumerator<float> Jwhngitem()
        {
            yield return Timing.WaitForSeconds(2f);
            foreach (Inventory.SyncItemInfo item in jwhng.GetAllItems())
            {
                jwhng.RemoveItem(item);
            }
            jwhng.ClearBroadcasts();
            jwhng.Broadcast(5, "<color=lime>[九尾狐内鬼]</color>\n<color=yello>你是九尾狐中的内鬼HP:350你有120s的准备时间</color>\n<color=yellow>丢下闪光弹切换隐藏模式</color>", false);
            jwhng.Broadcast(5, "<color=lime>[九尾狐内鬼]</color>\n<color=yello>补充说明 你在隐藏模式被九尾扫到会掉血但是不会暴露</color>\n<color=yellow>120s之前九尾不会对你造成伤害你也无法变身</color>", false);
            jwhng.AddItem(ItemType.KeycardChaosInsurgency);
            jwhng.AddItem(ItemType.GunE11SR);
            jwhng.AddItem(ItemType.Radio);
            jwhng.AddItem(ItemType.GrenadeFlash);
            jwhng.AddItem(ItemType.Adrenaline);
            Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(jwhng, 350)));


        }

        private IEnumerator<float> SecondCounter27()
        {
            for (; ; )
            {
                if(scp550yes == true)
                {
                    Vector3 pos2 = scp550.GetPosition();
                    float num2 = pos2.x + 3;
                    float num3 = pos2.y + 3;
                    float num4 = pos2.z + 3;
                    float num5 = pos2.x - 3;
                    float num6 = pos2.y - 3;
                    float num7 = pos2.z - 3;
                    
                    

                    foreach (Ragdoll ragdoll in UnityEngine.Object.FindObjectsOfType<Ragdoll>())
                    {
                        if ((ragdoll.transform.position.x <= num2) && (ragdoll.transform.position.x >= num5) && (ragdoll.transform.position.y <= num3) && (ragdoll.transform.position.y >= num6) && ((ragdoll.transform.position.z <= num4) && (ragdoll.transform.position.z >= num7)))
                        {
                            tssj++;
                            scp550.Broadcast(1, "<color=lime>[提示]吞噬尸体中进度</color>" + tssj,false);
                            if (scp550lv == 0)
                            {
                                if(tssj >= 14)
                                {
                                    tssj = 0;
                                    tssl++;
                                    meitunshi = true;
                                    scp550.AddHealth(100);
                                    Setrank_new("SCP550|吞噬尸体数量:" + tssl + "|等级:" + scp550lv,"red",scp550);

                                    NetworkServer.Destroy(ragdoll.gameObject);
                                }
                            }
                            if(scp550lv == 1)
                            {
                                if (tssj >= 12)
                                {
                                    tssj = 0;
                                    meitunshi = true;
                                    tssl++;
                                    scp550.AddHealth(100);
                                    Setrank_new("SCP550|吞噬尸体数量:" + tssl + "|等级:" + scp550lv, "red", scp550);

                                    NetworkServer.Destroy(ragdoll.gameObject);
                                }
                            }
                            if (scp550lv >= 2)
                            {
                                if (tssj >= 10)
                                {
                                    meitunshi = true;
                                    tssj = 0;
                                    tssl++;
                                    scp550.AddHealth(100);
                                    Setrank_new("SCP550|吞噬尸体数量:" + tssl + "|等级:" + scp550lv, "red", scp550);
                                    NetworkServer.Destroy(ragdoll.gameObject);
                                }
                            }

                            break;
                        }
                        else
                        {
                            tssj = 0;
                        }
                    }
                }
                if (scp550yes == true)
                {
                    if (tssl == 5)
                    {
                        meitunshi = true;
                        scp550lv = 1;
                        Setrank_new("SCP550|吞噬尸体数量:" + tssl + "|等级:" + scp550lv, "red", scp550);

                    }
                    if (tssl == 10)
                    {
                        meitunshi = true;
                        scp550lv = 2;
                        Setrank_new("SCP550|吞噬尸体数量:" + tssl + "|等级:" + scp550lv, "red", scp550);

                    }
                    if (tssl == 15)
                    {
                        meitunshi = true;
                        scp550lv = 3;
                        Setrank_new("SCP550|吞噬尸体数量:" + tssl + "|等级:" + scp550lv, "red", scp550);

                    }
                    if (tssl == 30)
                    {
                        meitunshi = true;
                        scp550lv = 4;
                        Setrank_new("SCP550|吞噬尸体数量:" + tssl + "|等级:" + scp550lv, "red", scp550);

                    }
                    if (scp550lv == 1)
                    {
                        scp550.AddHealth(2);
                    }
                    if (scp550lv == 2)
                    {
                        scp550.AddHealth(4);
                    }
                    if (scp550lv == 3)
                    {
                        scp550.AddHealth(6);
                    }
                    if (scp550lv == 4)
                    {
                        scp550.AddHealth(8);
                    }
                }
                yield return Timing.WaitForSeconds(1f);

            }
        }

        private IEnumerator<float> SecondCounter26()
        {
            for (; ; )
            {
                if(meitunshi == true)
                {
                    yield return Timing.WaitForSeconds(30f);
                    meitunshi = false;
                }
                if(meitunshi == false)
                {
                    if(scp550.GetHealth() >= 300)
                    {
                        scp550.AddHealth(-8);
                    }
                }
                yield return Timing.WaitForSeconds(1f);

            }
        }
        private IEnumerator<float> Fkyyztp()
        {
            yield return Timing.WaitForSeconds(2f);
            fkyyz.SetPosition(Map.GetRandomSpawnPoint(RoleType.Scp93989));
        }
        private IEnumerator<float> SecondCounter5()
        {
            for (; ; )
            {
                if(starttimer == true)
                {
                    yield return Timing.WaitForSeconds(200f);
                    foreach(ReferenceHub referenceHub in Player.GetHubs())
                    {
                        if(referenceHub.GetTeam() == Team.SCP)
                        {
                            referenceHub.AddHealth(50);
                        }
                    }
                    int sjsj2 = new System.Random().Next(1, 40);
                    Log.Info(sjsj2.ToString());

                    if (fkyyshuachu == false)
                    {
                        fkyyshuachu = true;
                        fkyyzyes = true;
                        fkyyzcardint = 2;
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            if (player3.GetRole() == RoleType.Spectator)
                            {
                                fkyyz = player3;
                                Setrank_new("奇迹的幻想之人", "red", fkyyz);
                                fkyyz.SetRole(RoleType.Tutorial);
                                fkyyzid = fkyyz.GetPlayerId();
                                Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(fkyyz, 500)));
                                Coroutines.Add(Timing.RunCoroutine(Fkyyztp()));
                                fkyyz.Broadcast(10, "<color=yellow>该人物正在测试 如果碰到</color><color=red>无敌 无限技能\n 或其他情况</color><color=yellow>请自觉退出服务器 理解万岁</color> \n<color=yellow>按~输入.help看使用方法</color>", false);
                                break;
                            }
                        }

                    }
                    if(fkyyzyes==true)
                    {
                        fkyyzcardint++;
                    }

                    if ((scp457die == false) && (scp457a == false))
                    {
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            if (player3.GetRole() == RoleType.Spectator)
                            {
                                scp457 = player3;
                                scp457a = true;
                                Log.Info("随机事件测试");

                                scp457id = scp457.GetPlayerId();
                                Setrank_new("SCP-457", "red", scp457);
                                scp457.SetRole(RoleType.Tutorial);
                                Coroutines.Add(Timing.RunCoroutine(Scp457tp()));
                                Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(scp457, 4000)));

                                Map.Broadcast("<color=red>[SCP457]</color>\n<color=lime>突破收容 请尽快将其重新收容</color>", 10, false);
                                scp457.Broadcast(10, "<color=#FFC0CB>---[SCP457]---</color>\n<color=#00FFFF>HP:4000  </color>你拥有一种特殊能力\n<color=#FFD700>在你周围的人都会扣血 持有SCP物品越多伤害越高</color>", false);
                                break;
                            }
                        }
                    }
                    if (sjsj2 == 1)
                    {
                        Map.Broadcast("<color=#BB1444>毒气泄漏！-事件：所有生存人类玩家将在30秒内扣除掉1-12hp</color>", 10, false);
                        foreach (ReferenceHub player3 in Player.GetHubs())

                        {
                            int kx = new System.Random().Next(1, 12);
                            if (player3.GetTeam() > Team.SCP)
                            {
                                player3.AddHealth(-kx);
                            }
                        }
                    }
                    if (sjsj2 == 2)
                    {
                        Map.Broadcast("<color=#BB1444>DD造反！！-事件：所有存活的Class-D获得“造反物品”</color>", 10, false);
                        foreach (ReferenceHub player3 in Player.GetHubs())

                        {
                            if (player3.GetRole() == RoleType.ClassD)
                            {
                                player3.AddItem(ItemType.GunCOM15);
                                player3.AddItem(ItemType.Ammo762);
                                player3.AddItem(ItemType.GunCOM15);
                            }
                        }
                    }
                    if (sjsj2 == 3)
                    {
                        Log.Info("随机事件测试");
                        Map.Broadcast("<color=#BB1444>博士的私货！！-事件：所有存活博士获得电磁炮x2和500hp</color>", 10, false);
                        foreach (ReferenceHub player3 in Player.GetHubs())

                        {
                            if (player3.GetRole() == RoleType.Scientist)
                            {
                                player3.AddItem(ItemType.MicroHID);
                                player3.AddItem(ItemType.MicroHID);
                                player3.SetHealth(player3.GetHealth() + 500);
                            }
                        }

                    }
                    if (sjsj2 == 4)
                    {
                        Map.Broadcast("<color=#BB1444>我要下班-事件：随机一名保安获得一张黑卡</color>", 10, false);
                        Log.Info("随机事件测试");
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            if (player3.GetRole() == RoleType.FacilityGuard)
                            {
                                player3.AddItem(ItemType.KeycardO5);
                                break;
                            }
                        }
                    }
                    if (sjsj2 == 5)
                    {
                        Log.Info("随机事件测试");
                        Map.Broadcast("<color=#BB1444>猪是的念来过倒-事件：在场的所有玩家get到了一个笑点</color>", 10, false);
                    }
                    if (sjsj2 == 6)
                    {
                        Map.Broadcast("<color=#BB1444>恭喜发财！-事件：所有存活玩家获得一大堆硬币</color>", 10, false);
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            player3.AddItem(ItemType.Coin);
                            player3.AddItem(ItemType.Coin);
                            player3.AddItem(ItemType.Coin);
                            player3.AddItem(ItemType.Coin);
                            player3.AddItem(ItemType.Coin);
                        }

                    }
                    if (sjsj2 == 7)
                    {
                        Map.Broadcast("<color=#BB1444>巧克力真好吃！-事件：花生吃掉自己手手</color>", 10, false);
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            if (player3.GetRole() == RoleType.Scp173)
                            {

                                player3.AddHealth(-50);
                            }
                        }

                    }
                    if (sjsj2 == 8)
                    {
                        Log.Info("随机事件测试");
                        Map.Broadcast("<color=#BB1444>无敌战神！-事件：花生-1HP并且无敌 恢复后满血复活qwq</color>", 10, false);
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            if (player3.GetRole() == RoleType.Scp173)
                            {
                                player3.SetHealth(1);
                                player3.SetGodMode(true);
                            }

                        }
                        Coroutines.Add(Timing.RunCoroutine(Wdzs()));

                        xhsnb = true;
                    }
                    if (sjsj2 == 9)
                    {
                        Map.Broadcast("<color=#BB1444>抱抱老爹！-事件：SCP-106随机传送到一名D级人员身边</color>", 10, false);
                        Log.Info("随机事件测试");
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            if (player3.GetRole() == RoleType.Scp106)
                            {
                                scp106a = player3;
                                break;
                            }
                        }
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            if (player3.GetRole() == RoleType.ClassD)
                            {
                                scp106a.SetPosition(player3.GetPosition());
                                break;
                            }

                        }
                    }
                    if (sjsj2 == 10)
                    {
                        Map.Broadcast("<color=#BB1444>毕业学徒！-事件：SCP-49-2变为SCP049</color>", 10, false);
                        Log.Info("随机事件测试");
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            if (player3.GetRole() == RoleType.Scp0492)
                            {
                                player3.SetRole(RoleType.Scp049, true);
                                break;
                            }
                        }
                    }
                    if (sjsj2 == 11)
                    {
                        Map.Broadcast("<color=#BB1444>吊销执照！-事件：SCP-49变为SCP-049-2</color>", 10, false);
                        Log.Info("随机事件测试");
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            if (player3.GetRole() == RoleType.Scp049)
                            {
                                pos5 = player3.GetPosition();
                                player3.SetRole(RoleType.Scp0492, true);

                                player3.SetHealth(5000);
                                break;
                            }
                        }
                    }
                    if (sjsj2 == 12)
                    {
                        Map.Broadcast("<color=#BB1444>敬老院！-事件：多出来一个老头</color>", 10, false);
                        Log.Info("随机事件测试");
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            if (player3.GetRole() == RoleType.Spectator)
                            {
                                player3.SetRole(RoleType.Scp106);
                                break;
                            }
                        }
                    }
                    if (sjsj2 == 13)
                    {
                        Map.Broadcast("<color=#BB1444>343的馈赠！-事件：一名玩家获得 电磁炮 手雷 黑卡</color>", 10, false);
                        Log.Info("随机事件测试");
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            if ((player3.GetTeam() > Team.SCP) && (player3.GetRole() != RoleType.Spectator))
                            {
                                player3.AddItem(ItemType.KeycardO5);
                                player3.AddItem(ItemType.MicroHID);
                                player3.AddItem(ItemType.GrenadeFrag);
                                break;
                            }
                        }
                    }
                    if (sjsj2 == 14)
                    {
                        Map.Broadcast("<color=#BB1444>DD们的复仇！-事件：全部D复活 并携带手枪</color>", 10, false);
                        Log.Info("随机事件测试");
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            if (player3.GetRole() == RoleType.Spectator)
                            {
                                player3.SetRole(RoleType.ClassD);
                                player3.AddItem(ItemType.GunCOM15);
                            }
                        }
                        csm = true;
                    }
                    if (sjsj2 == 15)
                    {
                        Map.Broadcast("<color=#BB1444>洗澡真舒服！-事件：老头洗白变成96</color>", 10, false);
                        Log.Info("随机事件测试");
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            if (player3.GetRole() == RoleType.Scp106)
                            {
                                player3.SetRole(RoleType.Scp096, true);
                            }
                        }
                    }
                    if (sjsj2 == 16)
                    {
                        Map.Broadcast("<color=#BB1444>泥巴真好玩！-事件：96变黑了</color>", 10, false);
                        Log.Info("随机事件测试");
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            if (player3.GetRole() == RoleType.Scp096)
                            {
                                player3.SetRole(RoleType.Scp106, true);
                            }
                        }
                    }
                    if (sjsj2 == 17)
                    {
                        Map.Broadcast("<color=#BB1444>我练功发自真心！-事件：一名D级变成SCP079</color>", 10, false);
                        Log.Info("随机事件测试");
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            if (player3.GetRole() == RoleType.ClassD)
                            {
                                player3.SetRole(RoleType.Scp079);
                                scpd79.Add(player3);
                                break;
                            }
                        }
                    }
                    if (sjsj2 == 18)
                    {
                        Map.Broadcast("<color=#BB1444>小人模式！-事件：所有玩家尺寸缩小</color>", 10, false);
                        Log.Info("随机事件测试");
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            SetPlayerScale(player3.gameObject, (float)0.7, (float)0.7, (float)0.7);
                        }
                    }
                    if (sjsj2 == 19)
                    {
                        Map.Broadcast("<color=#BB1444>杨永信网戒所！-事件：一名事件刷成079变回D级</color>", 10, false);
                        Log.Info("随机事件测试");
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            if (player3.GetRole() == RoleType.Scp079)
                            {
                                player3.SetRole(RoleType.ClassD);
                            }
                        }
                    }
                    if (sjsj2 == 20)
                    {
                        Log.Info("随机事件测试");
                        Map.Broadcast("<color=#BB1444>079帮助SCP！-事件：本回合SCP有5%几率开门</color>", 10, false);
                        bscp79 = true;
                    }
                    if (sjsj2 == 21)
                    {
                        Log.Info("随机事件测试");
                        Map.Broadcast("<color=#BB1444>调皮的传送门！-事件：10秒内100%触发随机门</color>", 10, false);
                        csm = true;
                    }
                    if (sjsj2 == 22)
                    {
                        Log.Info("随机事件测试");
                        Map.Broadcast("<color=#BB1444>乔碧萝的逆袭！-事件：乔碧萝恢复伤害</color>", 10, false);
                        qblcq = null;
                        qblcq2 = false;
                        scpqbl = null;
                        scpqbl3 = null;
                        scpqblid = null;
                        scpqblid2 = 0;

                    }
                    if (sjsj2 == 23)
                    {
                        Log.Info("随机事件测试");
                        Map.Broadcast("<color=#BB1444>空投弹药！-事件：所有人子弹加200发</color>", 10, false);
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            player3.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped5, player3.GetAmmo(EXILED.ApiObjects.AmmoType.Dropped5) + 200);
                            player3.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped7, player3.GetAmmo(EXILED.ApiObjects.AmmoType.Dropped7) + 200);
                            player3.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped9, player3.GetAmmo(EXILED.ApiObjects.AmmoType.Dropped9) + 200);
                        }
                    }
                    if (sjsj2 == 24)
                    {
                        Log.Info("随机事件测试");
                        Map.Broadcast("<color=#BB1444>肥宅快乐D！-事件：所有存活D级获得可乐</color>", 10, false);
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            if (player3.GetRole() == RoleType.ClassD)
                            {
                                player3.AddItem(ItemType.SCP207);
                            }
                        }
                    }
                    if (sjsj2 == 25)
                    {
                        Log.Info("随机事件测试");
                        Map.Broadcast("<color=#BB1444>花生油！-事件：复活3个小花生但HP：只有30HP</color>", 10, false);
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            if (player3.GetRole() == RoleType.Spectator)
                            {
                                time3++;
                                player3.SetRole(RoleType.Scp173);
                                player3.SetHealth(30);
                                if (time3 >= 3)
                                {
                                    break;
                                }

                            }
                        }

                    }
                    if (sjsj2 == 26)
                    {
                        Log.Info("随机事件测试");
                        Map.Broadcast("<color=#BB1444>九尾狐你们的快递到了！-事件：九尾狐出生点刷两个电磁炮</color>", 10, false);
                        Map.SpawnItem(ItemType.MicroHID, 500, Map.GetRandomSpawnPoint(RoleType.NtfCommander));
                        Map.SpawnItem(ItemType.MicroHID, 500, Map.GetRandomSpawnPoint(RoleType.NtfCommander));
                    }
                    if (sjsj2 == 27)
                    {
                        Log.Info("随机事件测试");
                        Map.Broadcast("<color=#BB1444>随机惊喜！-事件：随意地点刷一个黑卡</color>", 10, false);
                        Map.SpawnItem(ItemType.KeycardO5, 500, Map.GetRandomSpawnPoint(RoleType.ClassD));

                    }
                    if (sjsj2 == 28)
                    {
                        Log.Info("随机事件测试");
                        Map.Broadcast("<color=#BB1444>年久失修！-事件：设施门有几率无法开启</color>", 10, false);
                        bhsx = true;

                    }
                    if (sjsj2 == 29)
                    {
                        Log.Info("随机事件测试");
                        Map.Broadcast("<color=#BB1444>DD们多年的存款！-事件：Class-D获得 物资一份</color>", 10, false);
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            if (player3.GetRole() == RoleType.ClassD)
                            {
                                player3.AddItem(ItemType.GunE11SR);
                                player3.AddHealth(50);
                                player3.AddItem(ItemType.KeycardNTFCommander);
                            }
                        }
                    }
                    if (sjsj2 == 30)
                    {
                        Map.Broadcast("<color=#BB1444>哇！光头！-事件：多出来一个96</color>", 10, false);
                        Log.Info("随机事件测试");
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            if (player3.GetRole() == RoleType.Spectator)
                            {
                                player3.SetRole(RoleType.Scp096);
                                break;
                            }
                        }
                    }
                    if (sjsj2 == 31)
                    {
                        Map.Broadcast("<color=#BB1444>360安全管家！-事件：开始杀毒</color>", 10, false);
                        Log.Info("随机事件测试");
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            int 安全管家 = new System.Random().Next(1, 100);
                            if(安全管家 > 98)
                            {
                                误杀玩家 = player3;
                                Map.Broadcast("[<color=#66FF00>360安全管家</color>]\n" + 误杀玩家.GetNickname() + "木马病毒 已放入隔离区", 10, false);
                                误杀玩家.SetPosition(Map.GetRandomSpawnPoint(RoleType.Tutorial));
                                Coroutines.Add(Timing.RunCoroutine(Wshf()));

                            }
                        }
                    }
                    if(sjsj2 == 32)
                    {
                        Map.Broadcast("<color=#BB1444>中 国 制 造！-事件：门无法被破坏</color>", 10, false);
                        Log.Info("随机事件测试");
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            中国制造 = true;
                            Coroutines.Add(Timing.RunCoroutine(Zgzz()));

                        }
                    }
                    if (sjsj2 == 33)
                    {
                        Map.Broadcast("<color=#BB1444>哔哩哔哩 (゜-゜)つロ 干杯~！-事件：每人获取一瓶可乐</color>", 10, false);
                        Log.Info("随机事件测试");
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            player3.AddItem(ItemType.SCP207);
                        }
                    }
                    if (sjsj2 == 34)
                    {
                        Map.Broadcast("<color=#BB1444>SCP什么的，去你个大大卷！-事件：每人获取一个手雷</color>", 10, false);
                        Log.Info("随机事件测试");
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            player3.AddItem(ItemType.GrenadeFrag);
                        }
                    }
                    if (sjsj2 == 35)
                    {
                        Map.Broadcast("<color=#BB1444>我秃了！-事件：随机一位玩家 加100HP 获得抗性</color>", 10, false);
                        Log.Info("随机事件测试");
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            if(player3.GetTeam()!=Team.SCP)
                            {
                                tlid = player3.GetPlayerId();
                                player3.AddHealth(100);
                            }
                        }
                    }
                    if (sjsj2 == 36)
                    {
                        Map.Broadcast("<color=#BB1444>人群当中，突然钻出来个光头！-事件：96随机传送到一个幸运儿旁边</color>", 10, false);
                        Log.Info("随机事件测试");
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            if (player3.GetTeam() != Team.SCP && player3.GetRole() != RoleType.Tutorial)
                            {
                                foreach(ReferenceHub referenceHub in Player.GetHubs())
                                {
                                    if(referenceHub.GetRole() == RoleType.Scp096)
                                    {
                                        referenceHub.SetPosition(player3.GetPosition());
                                        break;
                                    }
                                }
                                break;
                            }
                        }
                    }
                    if (sjsj2 == 37)
                    {
                        Map.Broadcast("<color=#BB1444>杀手dd！-事件：复活一个dd杀手</color>", 10, false);
                        Log.Info("随机事件测试");
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            if(player3.GetRole() == RoleType.Spectator)
                            {
                                player3.SetRole(RoleType.ClassD);
                                yield return Timing.WaitForSeconds(0.2f);
                                player3.AddItem(ItemType.GunCOM15);
                                player3.AddItem(ItemType.SCP207);
                                player3.AddItem(ItemType.SCP268);
                                player3.AddItem(ItemType.Adrenaline);
                                player3.AddItem(ItemType.KeycardGuard);
                                break;

                            }
                        }
                    }
                    if (sjsj2 == 38)
                    {
                        Map.Broadcast("<color=#BB1444>畅通无阻！-事件：服务器全部门开启</color>", 10, false);
                        Log.Info("随机事件测试");
                        GameCore.Console.singleton.TypeCommand("open **");
                    }
                    if (sjsj2 == 39)
                    {
                        Map.Broadcast("<color=#BB1444>寸步难行！-事件：服务器全部门关闭并锁住10s</color>", 10, false);
                        Log.Info("随机事件测试");
                        GameCore.Console.singleton.TypeCommand("close **");
                        GameCore.Console.singleton.TypeCommand("lock **");
                        yield return Timing.WaitForSeconds(10f);
                        GameCore.Console.singleton.TypeCommand("unlock **");


                    }
                    if (Dio1 == false)
                    {
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            if (player3.GetRole() == RoleType.Spectator)
                            {
                                Coroutines.Add(Timing.RunCoroutine(SecondCounter6()));

                                Dio = player3;
                                Dio1 = true;
                                string diotaici = "你还记得你吃过多少块面包吗？";
                                int diotc = new System.Random().Next(1, 5);
                                if(diotc == 1)
                                {
                                    diotaici = "我真是High到不行啊！";
                                }
                                if (diotc == 2)
                                {
                                    diotaici = "吃我压路机啊！";
                                }
                                if (diotc == 3)
                                {
                                    diotaici = "你还记得你吃过多少块面包吗？";
                                }
                                if (diotc == 4)
                                {
                                    diotaici = "JOJO，我不想再做人了！";
                                }
                                Map.Broadcast("<color=#BB1444>Dio:</color>\n<color=lime>"+diotaici+"</color>", 10, false);
                                Dio.SetRole(RoleType.Tutorial);
                                Dio.SetPosition(Map.GetRandomSpawnPoint(RoleType.ChaosInsurgency));
                                Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(Dio, 500)));
                                Dio.AddItem(ItemType.Flashlight);
                                Dio.AddItem(ItemType.GunE11SR);
                                Dio.AddItem(ItemType.MicroHID);
                                Dio.AddItem(ItemType.MicroHID);
                                Dio.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped5, 400);
                                Dio.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped7, 400);
                                Dio.SetAmmo(EXILED.ApiObjects.AmmoType.Dropped9, 400);
                                Dio.AddItem(ItemType.KeycardNTFCommander);
                                Dio.ClearBroadcasts();
                                Dio.Broadcast(6, "<color=red>ko no dio da</color>\n<color=yellow>丢下手电筒使用时间停止</color>", false);
                                Setrank_new("Dio", "red", Dio);
                                Dio2.Add(Dio.GetUserId());
                                Coroutines.Add(Timing.RunCoroutine(Diotp()));

                                break;


                            }
                        }

                    }
                }
                yield return Timing.WaitForSeconds(1f);
            }
        }
        private IEnumerator<float> SecondCounter4()
        {
            for (; ; )
            {
                if (bhsx == true)
                {
                    njsxtimes = 0;
                    bhsx = false;
                }

                if (scp650yes == true)
                {
                    foreach (ReferenceHub player in Player.GetHubs())
                    {
                        if (player.GetPlayerId() == scp650id)
                        {
                            if (player.GetRole() != RoleType.Scp173)
                            {
                                scp650.SetGodMode(false);
                            }
                        }
                        int Rolenum = new System.Random().Next(1, 10);
                        if(Rolenum >= 6)
                        {
                            if(player.GetTeam()> Team.SCP)
                            {
                                scp650.SetPosition(player.GetPosition());
                            }
                        }
                    }
                }

                stealcd = false;
                Map.Broadcast("<color=#00FFFF>如果你有什么好点子或者游玩中有什么问题欢迎您加群哦\n1021889243</color>", 7, false);
                yield return Timing.WaitForSeconds(200f);
            }
        }
        private IEnumerator<float> SecondCounter15()
        {
            for (; ; )
            {
                if (!die && start)
                {
                    scp.AddItem(ItemType.Medkit);
                    scp.AddHealth(80);
                    maxtime = DateTime.Now.AddSeconds(120);
                }
                sjtz2 = false;
                coldwait233 = false;//038cd 120s
                yield return Timing.WaitForSeconds(120f);
            }
        }
        private IEnumerator<float> SecondCounter2()
        {
            for (; ; )
            {
                foreach (ReferenceHub p in Player.GetHubs())
                {
                    if(p.GetHealth()<=20)
                    {
                        Map.Broadcast(p.GetNickname()+"：你不要过来呀", 1, false);
                        p.AddItem(ItemType.SCP207);
                    }
                    if ((p.GetPosition().y <= -1000) && (p.GetPosition().y >= -1006))
                    {
                        int222++;
                        int Rolenum = new System.Random().Next(1, 14);
                        if(Rolenum == 1)
                        {
                            p.Broadcast(5, "<color=red>发生啥事？我练功发自真心</color>" + int222, false);
                        }
                        if (Rolenum == 2)
                        {
                            p.Broadcast(5, "<color=red>有节操~有节操~</color>" + int222, false);
                        }
                        if (Rolenum == 3)
                        {
                            p.Broadcast(5, "<color=red>一切都是屁！</color>" + int222, false);
                        }
                        if (Rolenum == 4)
                        {
                            p.Broadcast(5, "<color=red>DOTA！俺爸瞎啦！ 后妈！</color>" + int222, false);
                        }
                        if (Rolenum == 5)
                        {
                            p.Broadcast(5, "<color=red>妈妈回来！</color>" + int222, false);
                        }
                        if (Rolenum ==6)
                        {
                            p.Broadcast(5, "<color=red>你是三岁小孩吗？</color>" + int222, false);
                        }
                        if (Rolenum == 7)
                        {
                            p.Broadcast(5, "<color=red>哇啊啊啊啊↑</color>" + int222, false);
                        }
                        if (Rolenum == 8)
                        {
                            p.Broadcast(5, "<color=red>B裂 都被插 死B裂</color>" + int222, false);
                        }
                        if (Rolenum == 9)
                        {
                            p.Broadcast(5, "<color=red>俺感觉好好啊！</color>" + int222, false);
                        }
                        if (Rolenum == 10)
                        {
                            p.Broadcast(5, "<color=red>GAY佬！把你活吞！</color>" + int222, false);
                        }
                        if (Rolenum == 11)
                        {
                            p.Broadcast(5, "<color=red>AAAAAAAA圣诞快乐AAAAAA好快乐啊！</color>" + int222, false);
                        }
                        if (Rolenum == 12)
                        {
                            p.Broadcast(5, "<color=red>Wuaaaa~Wuaaaa~Wuaaaa~</color>" + int222, false);
                        }
                        if (Rolenum == 13)
                        {
                            p.Broadcast(5, "<color=red>啊~飞杀祖宗</color>" + int222, false);
                        }
                        if ((int222 == 10) || (int222 == 20) || (int222 == 30) || (int222 == 50) || (int222 == 60) || (int222 == 70) && (int222 == 80) && (int222 == 90))
                        {
                            p.AddItem(ItemType.MicroHID);
                            p.Broadcast(5, "<color=lime>[个人通知]/n</color><color=yellow>你已获得电磁炮*1</color>", false);
                        }
                        if (int222 >= 100)
                        {
                            foreach (ReferenceHub player in Player.GetHubs())
                            {
                                if (player.GetRole() == RoleType.Scp079)
                                {
                                    player.SetRole(RoleType.Spectator);
                                }
                            }
                            int222 = 0;
                            Map.Broadcast("<color=lime>SCP-079:你的电脑遇到问题 需要重新启动（蓝屏的钙,好喝的钙）</color>", 10, false);
                        }
                    }
                }

                yield return Timing.WaitForSeconds(20f);
            }
        }
        private IEnumerator<float> Hkjs()
        {
            foreach (ReferenceHub player in Player.GetHubs())
            {
                if (player.GetPlayerId() == jwhhkid)
                {
                    jwhhk.SetRole(RoleType.NtfScientist, false);
                    yield return Timing.WaitForSeconds(1f);
                    jwhhk.SetPosition(hkzb);
                    hktime = 0;
                    hrss = false;
                }
            }
        }
        private IEnumerator<float> SecondCounter()
        {
            for (; ; )
            {

                Dio.SetGodMode(false);
                scp457.SetGodMode(false);

                if (csm)
                {

                    csmtime++;
                    if (csmtime == 10)
                    {
                        csm = false;
                        csmtime = 0;
                    }
                }


                if(starttimer)
                {
                    deadtimer = deadtimer++;
                    waring1 = waring1++;
                    if (coldbc)
                    {
                        coldtime++;
                        if (coldtime == 80)
                        {
                            coldbc = false;
                            coldtime = 0;
                        }
                    }
                    if (coldtb)
                    {
                        coldtime2++;
                        if (coldtime2 == 300)
                        {
                            coldtb = false;
                            coldtime = 0;
                        }
                    }
                    if (deadtimer <= 30)
                    {

                        foreach (ReferenceHub player in Player.GetHubs())
                        {
                            if (player.GetRole() == RoleType.Spectator)
                            {
                                int num = new System.Random().Next(1, 100);
                                if ((num >= 0) && (num <= 0x19))
                                {
                                    if ((s173 == 0) && (player.GetRole() == RoleType.Spectator))
                                    {
                                        player.SetRole(RoleType.Scp173);
                                        s173 = 1;
                                    }
                                    else if ((s096 == 0) && (player.GetRole() == RoleType.Spectator))
                                    {
                                        player.ClearBroadcasts();
                                        player.SetRole(RoleType.Scp096);
                                        player.Broadcast(10, "<color=#FFC0CB>[消息]</color>\n由于你连接晚了\n已为你自动分配阵营接受挨打", false);
                                        player.Broadcast(10, "[<color=#FFA500>" + SCP173 + "</color> <color=#008000>" + SCP049 + "</color> <color=#FF8C00>" + SCP079 + "</color> <color=#808080>" + SCP096 + "</color> <color=#800000>" + SCP939_89 + "</color> <color=#CD5C5C>" + SCP939_53 + "</color> <color=#D2691E>" + SCP106 + "</color>]\n<color=#FF0000>本局您的队友</color>", false);
                                        s096 = 1;
                                        Log.Info("一名玩家延迟加入变为了: SCP096");
                                    }
                                    else if ((s106 == 0) && (player.GetRole() == RoleType.Spectator))
                                    {
                                        player.ClearBroadcasts();
                                        player.SetRole(RoleType.Scp106);
                                        player.Broadcast(10, "<color=#FFC0CB>[消息]</color>\n由于你连接晚了\n已为你自动分配阵营接受挨打", false);
                                        player.Broadcast(10, "[<color=#FFA500>" + SCP173 + "</color> <color=#008000>" + SCP049 + "</color> <color=#FF8C00>" + SCP079 + "</color> <color=#808080>" + SCP096 + "</color> <color=#800000>" + SCP939_89 + "</color> <color=#CD5C5C>" + SCP939_53 + "</color> <color=#D2691E>" + SCP106 + "</color>]\n<color=#FF0000>本局您的队友</color>", false);
                                        s106 = 1;
                                        Log.Info("一名玩家延迟加入变为了: SCP106");
                                    }
                                    else if ((s939_53 == 0) && (player.GetRole() == RoleType.Spectator))
                                    {
                                        player.ClearBroadcasts();
                                        player.SetRole(RoleType.Scp93953);
                                        player.Broadcast(10, "<color=#FFC0CB>[消息]</color>\n由于你连接晚了\n已为你自动分配阵营接受挨打", false);
                                        player.Broadcast(10, "[<color=#FFA500>" + SCP173 + "</color> <color=#008000>" + SCP049 + "</color> <color=#FF8C00>" + SCP079 + "</color> <color=#808080>" + SCP096 + "</color> <color=#800000>" + SCP939_89 + "</color> <color=#CD5C5C>" + SCP939_53 + "</color> <color=#D2691E>" + SCP106 + "</color>]\n<color=#FF0000>本局您的队友</color>", false);
                                        s939_53 = 1;
                                        Log.Info("一名玩家延迟加入变为了: SCP939_53");
                                    }
                                    else if ((s939_89 == 0) && (player.GetRole() == RoleType.Spectator))
                                    {
                                        player.ClearBroadcasts();
                                        player.SetRole(RoleType.Scp93989);
                                        player.Broadcast(10, "<color=#FFC0CB>[消息]</color>\n由于你连接晚了\n已为你自动分配阵营接受挨打", false);
                                        player.Broadcast(10, "[<color=#FFA500>" + SCP173 + "</color> <color=#008000>" + SCP049 + "</color> <color=#FF8C00>" + SCP079 + "</color> <color=#808080>" + SCP096 + "</color> <color=#800000>" + SCP939_89 + "</color> <color=#CD5C5C>" + SCP939_53 + "</color> <color=#D2691E>" + SCP106 + "</color>]\n<color=#FF0000>本局您的队友</color>", false);
                                        s939_89 = 1;
                                        Log.Info("一名玩家延迟加入变为了: SCP939_89");
                                    }
                                    else if ((s049 == 0) && (player.GetRole() == RoleType.Spectator))
                                    {
                                        player.SetRole(RoleType.Scp049);
                                        s049 = 1;
                                    }
                                    else
                                    {
                                        player.SetRole(RoleType.ClassD);
                                    }
                                }
                                else if ((num >= 0x33) && (num <= 100))
                                {
                                    player.SetRole(RoleType.ClassD);
                                }
                                else if ((num >= 0x1a) && (num <= 50))
                                {
                                    player.SetRole(RoleType.FacilityGuard);
                                }
                                else
                                {
                                    player.SetRole(RoleType.ClassD);
                                }
                                break;
                            }
                        }
                    }
                }


                yield return Timing.WaitForSeconds(1f);
            }
        }
        public void ScpSpawn()
        {
            if (!die)
            {
                scp.SetRole(RoleType.Tutorial,true);
                scp.AddItem(ItemType.Disarmer);
                scp.AddItem(ItemType.Flashlight);
                scp.AddItem(ItemType.KeycardGuard);
                scp.AddItem(ItemType.Radio);
                scp.AddItem(ItemType.GunMP7);
                Setrank_new("SCP-999", "pink", scp);
                Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(scp, 4000)));
                scp.ClearBroadcasts();
                scp.Broadcast(10, "[<color=red>SCP-999</color>]\n<color=yellow>去给人们带去欢乐吧</color>", false);
                scp.SetAmmo(AmmoType.Dropped5, 500);
                scp.SetAmmo(AmmoType.Dropped7, 500);
                scp.SetAmmo(AmmoType.Dropped9, 500);
                scp.SendConsoleMessage(string.Concat(new object[] { "\nSCP999插件说明:\nSCP999拥有[", 4000, "]血量,攻击到的对象将恢复[", 5, "]的血量,SCP999每[", 150, "]秒会回复80HP,SCP999不影响游戏结束条件" }), "green");
                start = true;
                scp_999.Add(scp.GetUserId());
                scp999tp = true;
                Log.Info("SCP999已刷新，玩家为:" + scp.GetNickname() + start.ToString());
            }
        }
        public void On914KnobChange(ref Scp914KnobChangeEvent ev)
        {
            Vector3 pos2 = ev.Player.GetPosition();
            float num2 = pos2.x + 10;
            float num3 = pos2.y + 10;
            float num4 = pos2.z + 10;
            float num5 = pos2.x - 10;
            float num6 = pos2.y - 10;
            float num7 = pos2.z - 10;

            foreach (ReferenceHub player3 in Player.GetHubs())
            {
                if ((player3.GetPosition().x <= num2) && (player3.GetPosition().x >= num5) && (player3.GetPosition().y <= num3) && (player3.GetPosition().y >= num6) && ((player3.GetPosition().z <= num4) && (player3.GetPosition().z >= num7)))
                {
                ev.Player.Broadcast(5, "914当前设置：" + ev.KnobSetting + "更改人员：" + ev.Player.GetNickname(), false);
                }
            }

        }
        public void OnScp096Enrage(ref Scp096EnrageEvent ev)
        {

            Map.Broadcast("<color=red>[警告]</color>\n"+ev.Player.GetNickname() +"<color=lime>的脸被欣赏了</color>", 5,false);

        }
        public void OnRoundStart()
        {
            intercomeArea = null;
            Coroutines.Add(Timing.RunCoroutine(GuanZhanYouXi()));

            Coroutines.Add(Timing.RunCoroutine(CheckFor939Intercom()));
            Coroutines.Add(Timing.RunCoroutine(SecondCounter20()));
            Coroutines.Add(Timing.RunCoroutine(SetNineFox()));

            Coroutines.Add(Timing.RunCoroutine(RenWuFenPei()));

            if (int222>= 50)
            {
                int222 = 50;
            }    
            diyicizhixingzheli = true;
            Map.SpawnItem(ItemType.GunCOM15, 500, Map.GetRandomSpawnPoint(RoleType.Scp173));
            starttimer = true;
            Map.Broadcast("<color=lime>插件版本"+DateTime.Today+"bate4</color> <color=yellow>理解万岁</color>", 5, false);
            foreach (GameObject door in GameObject.FindGameObjectsWithTag("Door"))
            {
                if (new System.Random().Next(1, 12) == 5)
                {
                    Vector3 pos = new Vector3(door.transform.position.x, door.transform.position.y + (float)2.0, door.transform.position.z);
                    Map.SpawnItem(ItemType.Coin, 500, pos);
                    time2++;
                }
            }
            Map.Broadcast("<color=lime>本局已生成</color>" + time2 + "<color=lime>个幸运硬币</color>\n 你能找到吗awa？", 10, false);
            Map.Broadcast("<color=red>让我看看 哪个小可爱这么幸运 获得幸运玩家呢？</color>", 1, false);
            Map.Broadcast("<color=yellow>让我看看 哪个小可爱这么幸运 获得幸运玩家呢？</color>", 1, false);
            Map.Broadcast("<color=lime>让我看看 哪个小可爱这么幸运 获得幸运玩家呢？</color>", 1, false);
            foreach (ReferenceHub player in Player.GetHubs())
            {
                xywj = player;
                xywjid = xywj.GetUserId();
            }
            Map.Broadcast("<color=lime>↓↓↓↓本回合幸运玩家↓↓↓↓</color>\n" + "<color=lime>" + xywj.GetNickname() + "</color>\n<color=red>你可以按~自选人物了</color>", 2, false);
            Map.Broadcast("<color=lime>↓↓↓↓本回合幸运玩家↓↓↓↓</color>\n" + "<color=red>" + xywj.GetNickname() + "</color>\n<color=red>你可以按~自选人物了</color>", 2, false);
            Map.Broadcast("<color=lime>↓↓↓↓本回合幸运玩家↓↓↓↓</color>\n" + "<color=green>" + xywj.GetNickname() + "</color>\n<color=red>你可以按~自选人物了</color>", 2, false);
            Coroutines.Add(Timing.RunCoroutine(Xywjsx()));

            xywj.SendConsoleMessage(".s173 变为173\n.s106 变为106\n.sD 变为D级\n.sS 变为科学家\n.sG 变为保安\n.s96选择当96\n注意这会清除你的特殊人物", "green");
            Map.Broadcast("<color=yellow>国服攻击严重 请务必加群：</color><color=#66FFFF>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>", 1, false);
            Map.Broadcast("<color=yellow>国服攻击严重 请务必加群：</color><color=#66FFCC>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>", 1, false);
            Map.Broadcast("<color=yellow>国服攻击严重 请务必加群：</color><color=#66FF99>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>", 1, false);
            Map.Broadcast("<color=yellow>国服攻击严重 请务必加群：</color><color=#66FF66>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>", 1, false);
            Map.Broadcast("<color=yellow>国服攻击严重 请务必加群：</color><color=#66FF33>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>", 1, false);
            Map.Broadcast("<color=yellow>国服攻击严重 请务必加群：</color><color=#66FF00>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>", 1, false);
            Map.Broadcast("<color=yellow>国服攻击严重 请务必加群：</color><color=#66CCFF>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>", 1, false);
            Map.Broadcast("<color=yellow>国服攻击严重 请务必加群：</color><color=#66CCCC>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>", 1, false);
            Map.Broadcast("<color=yellow>国服攻击严重 请务必加群：</color><color=#CCFFFF>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>", 1, false);
            Map.Broadcast("<color=yellow>国服攻击严重 请务必加群：</color><color=#CCFFCC>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>", 1, false);
            Map.Broadcast("<color=yellow>国服攻击严重 请务必加群：</color><color=#CCFF99>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>", 1, false);
            Map.Broadcast("<color=yellow>国服攻击严重 请务必加群：</color><color=#CCFF66>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>", 1, false);
            Map.Broadcast("<color=yellow>国服攻击严重 请务必加群：</color><color=#CCFF33>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>", 1, false);
            Map.Broadcast("<color=yellow>国服攻击严重 请务必加群：</color><color=#CCFF00>1021889243</color><color=yellow>以便最快速度获得服务器动态</color>", 1, false);
            int num = 0;
            foreach (ReferenceHub player in Player.GetHubs())
            {
                num++;
            }
            if (num < 3)
            {
                die = true;
                Log.Info("玩家不足三人,SCP999无法刷新");
            }
            else
            {
                scp999yes = true;
                scp49jyes = true;
            }


            times = 0;


            coldwait233 = false;
            starttimer = true;
            roundstart = true;
            deadtime = true;
            Map.Broadcast("<color=yellow>回合结束后如果您出现 服务器重启中0% 请点击esc 点击快速重连</color>", 5, false);
            Map.Broadcast("<color=#FF0000>警告:</color>站点发生收容失效,Alpha弹头协议将会摧毁此站点\n请在30分钟内遏制重新收容所有SCP项目", 10, false);
            Map.Broadcast("<color=#FFFF00>[进入投降模式]</color>\n---|<color=#FF0000>点击键盘上的 ~ 键[数字1左边]</color>|---\n输入<color=#9400D3>.tx</color>即可进入<color=#9400D3>投降模式</color>", 2, false);
            Map.Broadcast("<color=#FFFF00>[进入投降模式]</color>\n---|<color=#FF0000>点击键盘上的 ~ 键[数字1左边]</color>|---\n输入<color=#FFFF33>.tx</color>即可进入<color=#9400D3>投降模式</color>", 2, false);
            Map.Broadcast("<color=#FFFF00>[进入投降模式]</color>\n---|<color=#FF0000>点击键盘上的 ~ 键[数字1左边]</color>|---\n输入<color=#66FF33>.tx</color>即可进入<color=#9400D3>投降模式</color>", 2, false);
            Map.Broadcast("<color=#FFFF00>[进入投降模式]</color>\n---|<color=#FF0000>点击键盘上的 ~ 键[数字1左边]</color>|---\n输入<color=#00CCFF>.tx</color>即可进入<color=#9400D3>投降模式</color>", 2, false);
            Map.Broadcast("<color=#FFFF00>[进入投降模式]</color>\n---|<color=#FF0000>点击键盘上的 ~ 键[数字1左边]</color>|---\n输入<color=#FF9900>.tx</color>即可进入<color=#9400D3>投降模式</color>", 2, false);
            
            Coroutines.Add(Timing.RunCoroutine(ChopperThread()));

        }
        public void End()
        {
            hdjjs = null;
            hdjjsid = 0;
            时间 = "";
            地点 = "";
            人物 = "";
            事件 = "";
            句子 = "";
            缺少 = "";
            timestop = 0;
            timesjw = 0;
            scp49j = null;
            scp49jid = 0;
            中国制造 = false;
            Gears博士id = 0;
            Gears博士 = null;
            zybuse = false;
            fkyyshuachu = false;
            fkyyz = null;
            fkyyzid = 0;
            fkyyzyes = false;
            bindljf = false;
            bindtys = false;
            bindjzsj = false;
            scp79 = false;
            scp550lv = 0;
            tssl = 0;
            mz = null;
            mzid = 0;
            mzyes = false;
            scp035yes = false;
            xitonghedan = false;
            jwhngitem = true;
            this.scp079id = -1;
            h = false;
            roundstart = false;
            choise = false;
            scp035goout = false;
            jwhng = null;
            jwhngwufashanghai = false;
            jwhhkid = 0;
            jwhngyes = false;
            jwhngshuachu = false;
            scp550shuachu = false;
            Timing.KillCoroutines(Coroutines);
            Coroutines.Clear();
            scp999yes = false;
            scp = null;
            die = true;
            start = false;
            scp_999.Clear();
            card = 0;
            s = 0;
            d = 0;
            SCP049 = "";
            SCP079 = "";
            SCP096 = "";
            SCP939_53 = "";
            SCP939_89 = "";
            SCP106 = "";
            KillerID = 0;
            PlayerID = 0;
            RoleSet = 0;
            s173 = 0;
            s049 = 0;
            s096 = 0;
            s939_53 = 0;
            s939_89 = 0;
            s106 = 0;
            Guardnum = 0;
            deadtimer = 0;
            waring1 = 0;
            ini10 = 0;
            coldwait233 = false;
            Dio = null;
            Dio1 = false;
            Dio2.Clear();
            tiems = 0;
            sjtz1 = false;
            scp076 = null;
            scp035yes = false;
            scp076yes = false;
            scp2818 = null;
            scp2818pick = false;
            scp1143a = false;
            scp1143 = null;
            times = 0;
            Map.Broadcast("<color=yellow>GG 游戏结束 \n 现在可以打队友了</color>", 5, false);
            jljy = null;
            jljy1 = false;
            jljy2.Clear();
            jljyzb = false;
            sjtz2 = false;
            ylb1 = false;
            HDZHG2.Clear();
            coldwait233 = false;
            coldbc = false;
            coldtb = false;
            coldtime = 0;
            mtf = 0;
            chaos = 0;
            mtfchange = 0;
            chaoschange = 0;
            round = 0;
            Array.Clear(touxiang, 0, touxiang.Length);
            playernum = 0;
            roundstart = false;
            player233.Clear();
            starttimer = false;
            deadtime = false;
            KillerID = 0;
            PlayerID = 0;
            RoleSet = 0;
            Guardnum = 0;
            deadtimer = 0;
            waring1 = 0;
            ini10 = 0;
            Dio = null;
            Dio1 = false;
            Dio2.Clear();
            xywj = null;
            xywjid = null;
            //181end尾部
            bpb = false;
            bpb2.Clear();
            xhsnb2 = 0;
            scp2818id = 0;
            xhsnb = false;
            scp1143id = 0;
            xp = 0;
            lv = 0;
            coldbc = false;
            coldtb = false;
            HDZHG2.Clear();
            coldtime = 0;
            mtf = 0;
            chaos = 0;
            mtfchange = 0;
            chaoschange = 0;
            round = 0;
            Array.Clear(touxiang, 0, touxiang.Length);
            playernum = 0;
            roundstart = false;
            player233.Clear();
            starttimer = false;
            deadtime = false;
            SCP173 = "";
            sjqx = false;
            yshkq = false;
            bhsx = false;
            gjtr = 0;
            scp1577pick = false;
            scp1577id = new List<int>();
            scp1577pos = new Vector3();
        scp3108shotyes = false;
            scp3108shotatplayerpos = new Vector3();
        scp3108playerid = 0;
            scp3108pick = false;
            a127d = false;
            HDZHG = null;
            scp650yes = false;
            scp650 = null;
            scp650id = 0;
            scp073 = null;
            scp073a = false;
            scp073zb = true;
            scp076id = 0;
            scp005 = false;
            scp005aid = 0;
            time2 = 0;
            scp457die = false;
            scp457 = null;
            scp457a = false;
            scp457id = 0;
            xtd = null;
            xtdid = 0;
            a127 = false;
            a127b = 0;
            a127c = false;
            scp914mid = 0;
            scp914m = null;
            scp1143 = null;
            scp1143id = 0;
            scp1143a = false;
            csm = false;
            jwhhk = null;
            jwhhkid = 0;
            qblcq2 = false;
            qblcq = null;
            scpqbl3 = null;
            scp682.Clear();
            scp939id = 0;
            jkl = false;
            jklid = null;
            //181end头
            times5 = 1;
            scp035 = null;
            scp035id = 0;
            scp181id = 0;
            cxkid = 0;
            scp817id = 0;
            scp817 = null;
            cxk = null;
            cxkyes = false;
            scp817yes = false;
            D9341 = null;
            D9341id = 0;
            D9341Item = null;
            D9341yes = false;
            D9341zb = new Vector3();
            jntm = false;
            starttimer = false;
            scp2006 = null;
            scp2006a.Clear();
            scp2006id = 0;
            times3 = 0;
            deadtimer = 0;
            scpqblid2 = 0;
            scpqbl = null;
            scpqblid = null;
        }
        public void OnRoundEnd()
        {
            End();
        }
        public void OnPlayerJoin(PlayerJoinEvent ev)
        {
            if (ev.Player.GetUserId() == "76561198377975833@steam")
            {
                Map.Broadcast("<color=green>"+ev.Player.GetNickname()+ "日常献祭十年寿命换scp! </color>", 8, false);

            }
            if (ev.Player.GetUserId() == "76561198369468432@steam")
            {
                Map.Broadcast("<color=#6699FF>发出高价回收的声音:50包邮!</color>", 2, false);
                Map.Broadcast("<color=#FF0033>发出高价回收的声音:50包邮!</color>", 2, false);
                Map.Broadcast("<color=#FFFF00>发出高价回收的声音:50包邮!</color>", 2, false);

            }
            if (ev.Player.GetUserId() == "76561198893112896@steam")
            {
                Map.Broadcast("<color=yellow>砸哇路多，DIO用『世界』暂停了时间并且加入了服务器</color>", 8, false);
            }
            if (ev.Player.GetUserId() == "76561198385564103@steam")
            {
                Map.Broadcast("<color=#33FFFF>" + ev.Player.GetNickname() + ":我来装逼了</color>", 1, false);
                Map.Broadcast("<color=#FF6633>" + ev.Player.GetNickname() + ":我来装逼了</color>", 1, false);
                Map.Broadcast("<color=#00FF33>" + ev.Player.GetNickname() + ":我来装逼了</color>", 1, false);
                Map.Broadcast("<color=#666699>" + ev.Player.GetNickname() + ":我来装逼了</color>", 1, false);
                Map.Broadcast("<color=#00FFCC>" + ev.Player.GetNickname() + ":我来装逼了</color>", 1, false);
                Map.Broadcast("<color=#CC99FF>" + ev.Player.GetNickname() + ":我来装逼了</color>", 1, false);
                Map.Broadcast("<color=#FFFFFF>" + ev.Player.GetNickname() + ":我来装逼了</color>", 1, false);
            }
            
            if (ev.Player.GetUserId() == "76561198997348090@steam")
            {
                Map.Broadcast("<color=#FFFF66>顺顺大魔王骑着皮皮虾唱着歌谣进来了:皮皮虾我们走去找一个好朋友!</color>", 1, false);
                Map.Broadcast("<color=#CCFF00>顺顺大魔王骑着皮皮虾唱着歌谣进来了:皮皮虾我们走去找一个好朋友!</color>", 1, false);
                Map.Broadcast("<color=#99FF00>顺顺大魔王骑着皮皮虾唱着歌谣进来了:皮皮虾我们走去找一个好朋友!</color>", 1, false);
                Map.Broadcast("<color=#FF6633>顺顺大魔王骑着皮皮虾唱着歌谣进来了:皮皮虾我们走去找一个好朋友!</color>", 1, false);
                Map.Broadcast("<color=#FF3300>顺顺大魔王骑着皮皮虾唱着歌谣进来了:皮皮虾我们走去找一个好朋友!</color>", 1, false);
                Map.Broadcast("<color=#66FF00>顺顺大魔王骑着皮皮虾唱着歌谣进来了:皮皮虾我们走去找一个好朋友!</color>", 1, false);
                Map.Broadcast("<color=#6666FF>顺顺大魔王骑着皮皮虾唱着歌谣进来了:皮皮虾我们走去找一个好朋友!</color>", 1, false);
                Map.Broadcast("<color=#FF0033>顺顺大魔王骑着皮皮虾唱着歌谣进来了:皮皮虾我们走去找一个好朋友!</color>", 1, false);
                Map.Broadcast("<color=#66CCFF>顺顺大魔王骑着皮皮虾唱着歌谣进来了:皮皮虾我们走去找一个好朋友!</color>", 1, false);
            }
            if (ev.Player.GetUserId() == "76561198145812844@steam")
            {
                Map.Broadcast("<color=#66FF00>[注意！老阴比]</color>" + ev.Player.GetNickname() + "<color=#FFFF00>进入游戏，各位注意自己的菊花</color>", 8, false);
            }
            if (ev.Player.GetUserId() == "76561198401019684@steam")
            {
                Map.Broadcast("<color=#66FF00>[注意！49痴汉]</color>" + ev.Player.GetNickname() + "<color=#FFFF00>进入游戏</color>", 8, false);
            }
            if (ev.Player.GetUserId() == "76561198441344563@steam")
            {
                Map.Broadcast("<color=#66FF00>[全服最帅的人到达战场]</color>" + ev.Player.GetNickname() + "<color=#FFFF00>进入游戏</color>", 8, false);
            }
            if (ev.Player.GetUserId() == "76561198816705835@steam")
            {
                Map.Broadcast("<color=#66FF00>[全服最菜的大佬]</color>" + ev.Player.GetNickname() + "<color=#FFFF00>进入游戏</color>", 8, false);
            }
            if (ev.Player.GetUserId() == "76561198149835838@steam")
            {
                Map.Broadcast("<color=red>[SCP079保护协会会长]</color>" + ev.Player.GetNickname() + "<color=#red>进入游戏</color>", 8, false);
            }
            if (ev.Player.GetUserId() == "76561198425823494@steam")
            {
                Map.Broadcast("<color=#66FF00>[全服最帅的人到达战场]</color>" + ev.Player.GetNickname() + "<color=#FFFF00>进入游戏</color>", 8, false);
            }
            string name = ev.Player.GetNickname();
            if (!player233.Contains(ev.Player))
            {
                player233.Add(ev.Player);
            }
            playernum = 0;
            foreach(ReferenceHub referenceHub in Player.GetHubs())
            {
                playernum++;
            }
            object[] objArray1 = new object[] { "<color=#FFD700>[", name, "]</color>，欢迎你加入本服务器\n当前人数:<color=#00FF00>[", playernum, "/35]</color>\n+本服插件:<color=#00FFFF>很多打不下</color>+" };
            ev.Player.Broadcast(5, string.Concat(objArray1), false);

            ev.Player.Broadcast(5, "<color=yellow>[提示]</color>\n<color=lime>如果你想获得玩家编号\n按~开启控制台，在控制台输入.list获取玩家编号</color>", false);
            ev.Player.Broadcast(10, "<color=#BB1444>如果你看到这条消息证明随机事件插件已经在运行</color>\n<color=#FFFF00>如有破坏游戏体验等问题请在群内支出qwq</color>", false);
            int num3 = new System.Random().Next(1, 11);
            if (num3 == 1)
            {
                ev.Player.Broadcast(5, "<color=#FF3300>[SCP038]</color>\n<color=#FFFF00>万象树在012房间可以复制物品qwq</color>", false);
            }
            if (num3 == 2)
            {
                ev.Player.Broadcast(5, "<color=#FF3300>[通知]</color>\n<color=#FFFF00>插件介绍还在咕咕咕</color>", false);
            }
            if (num3 == 3)
            {
                ev.Player.Broadcast(5, "<color=#FF3300>[SCP817]</color>\n<color=#FFFF00>随意人\n150秒变换一次角色</color>", false);
            }
            if(num3 == 4)
            {
                ev.Player.Broadcast(5, "<color=#FF3300>[九尾狐内鬼]</color><color=#FFFF00>\n前120秒无法被九尾伤害 120s后会被九尾狐伤害\n伪装模式无法对九尾狐造成伤害</color>", false);
            }
            if (num3 == 5)
            {
                ev.Player.Broadcast(5, "<color=#FF3300>[SCP999]</color><color=#FFFF00>\n打人为回血对SCP回血量为5对人类回血量为2 玩法提示：\n开局找保安交易板子 去914和成USP可以造成伤害哦(仅限于自卫 不可随意杀人)</color>", false);
            }
            if (num3 == 6)
            {
                ev.Player.Broadcast(5, "<color=#FF3300>[蔡徐坤]</color><color=#FFFF00>\n丢下手电筒可以使用鸡你太美\n玩法提示：开局手电筒留到AB电梯直接踹门逃生</color>", false);
            }
            if (num3 == 7)
            {
                ev.Player.Broadcast(5, "<color=#FF3300>[蔡徐坤]</color><color=#FFFF00>\n丢下手电筒可以使用鸡你太美\n玩法提示：开局手电筒留到AB电梯直接踹门逃生</color>", false);
            }
            if (num3 == 8)
            {
                ev.Player.Broadcast(5, "<color=#FF3300>[提示]</color><color=#FFFF00>\n九尾狐指挥官和混沌指挥官 有特殊功能哦\n玩法提示：可以输入.help查看你的指令</color>", false);
            }
            if (num3 == 9)
            {
                ev.Player.Broadcast(5, "<color=#FF3300>[SCP079]</color><color=#FFFF00>\n开局你可以选择帮助SCP还是人类\n玩法提示：如果不选择则为默认帮助SCP</color>", false);
            }
            if (num3 == 10)
            {
                ev.Player.Broadcast(5, "<color=#FF3300>[SCP181]</color><color=#FFFF00>\n你在老头空间做错路不会死哦\n玩法提示：在老头空间不要走得太深会掉下去</color>", false);
            }
            if (num3 == 11)
            {
                ev.Player.Broadcast(5, "<color=#FF3300>[SCP181]</color><color=#FFFF00>\n你在老头空间做错路不会死哦\n玩法提示：在老头空间不要走得太深会掉下去</color>", false);
            }
            int num = new System.Random().Next(1, 101);
            if (num <= 20)
            {
                int num2 = new System.Random().Next(1, 7);
                if (num2 == 1)
                {
                    ev.Player.Broadcast(7, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>恩断义绝警告</color>", false);
                }
                else if (num2 == 2)
                {
                    ev.Player.Broadcast(7, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>你妈的，为什么</color>", false);
                }
                else if (num2 == 3)
                {
                    ev.Player.Broadcast(7, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>你打游戏像蔡徐坤</color>", false);
                }
                else if (num2 == 4)
                {
                    ev.Player.Broadcast(7, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>你长得像乔碧萝</color>", false);
                }
                else if (num2 == 5)
                {
                    ev.Player.Broadcast(7, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>哈哈哈弱爆了</color>", false);
                }
                else
                {
                    ev.Player.Broadcast(7, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>噗太菜了</color>", false);
                }
            }
            if ((num >= 0x15) && (num <= 40))
            {
                int num2 = new System.Random().Next(1, 7);
                if (num2 == 1)
                {
                    ev.Player.Broadcast(7, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>两行泪两行泪</color>", false);
                }
                else if (num2 == 2)
                {
                    object[] objArray2 = new object[] { "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>", num, "</color>%]\n<color=#FF00FF>喵哈哈哈哈哈哈哈才", num, "%</color>" };
                    ev.Player.Broadcast(7, string.Concat(objArray2), false);
                }
                else if (num2 == 3)
                {
                    ev.Player.Broadcast(7, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>LOL一般般啦别伤心美好的人生</color>", false);
                }
                else
                {
                    ev.Player.Broadcast(7, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>=w= qwq qaq awa AWSL</color>", false);
                }
            }
            if ((num >= 0x29) && (num <= 0x31))
            {
                if (new System.Random().Next(1, 6) == 1)
                {
                    ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>告诉你一个秘密,下班的神秘代码复制到迅雷</color>", false);
                }
                else if (new System.Random().Next(1, 6) == 2)
                {
                    ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>神秘代码不可能给你的233</color>", false);
                }
                else
                {
                    ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>其实50%以下比50%还好相信我!</color>", false);
                }
            }
            if (num == 50)
            {
                int num5 = new System.Random().Next(1, 6);
                switch (num5)
                {
                    case 1:
                        ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>也不差嘛~不过电磁炮可能合不出来哇咔咔</color>", false);
                        goto Label_037D;

                    case 2:
                        ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>50%是好还是坏呢</color>", false);
                        goto Label_037D;

                    case 3:
                        ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>改编不是乱编!戏说不是胡说!</color>", false);
                        break;
                }
                if (num5 == 3)
                {
                    ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>改编不是乱编!戏说不是胡说!</color>", false);
                }
                else
                {
                    ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>50%...如果加1%会不会变得更强呢?</color>", false);
                }
            }
        Label_037D:
            if ((num >= 51) && (num <= 80))
            {
                int num6 = new System.Random().Next(1, 6);
                switch (num6)
                {
                    case 1:
                        ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>我觉得海星</color>", false);
                        goto Label_0468;

                    case 2:
                        ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>快乐DD每一天</color>", false);
                        goto Label_0468;

                    case 3:
                        ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>不行啊，太短了满足不了我</color>", false);
                        break;
                }
                if (num6 == 3)
                {
                    ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>不行啊，太短了满足不了我</color>", false);
                }
                else
                {
                    ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>你看你队友打游戏像蔡徐坤</color>", false);
                }
            }
        Label_0468:
            if ((num >= 80) && (num <= 90))
            {
                int num2 = new System.Random().Next(1, 6);

                if (num2 == 1)
                {
                    ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>妈妈咪耶，欧皇？我先吸掉你欧气为敬!</color>", false);
                }
                if (num2 == 2)
                {
                    ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>wdnm你太强了</color>", false);
                }
                if (num2 == 3)
                {
                    ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>你的欧气已被后台转移到服主身上</color>", false);
                }
                if (num2 == 4)
                {
                    ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>你的人品今天已经花在本服了,切勿抽卡233!</color>", false);
                }

            }

            if (num == 100)
            {
                if (new System.Random().Next(1, 6) <= 3)
                {
                    ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>....不就是100%[才不是羡慕],你可以把这条信息截图给服主秀一波了</color>", false);
                }
                else
                {
                    ev.Player.Broadcast(15, "=w= 经过本鱼的检测,你本回合人品指数为\n[<color=#FFC0CB>" + num + "</color>%]\n<color=#FF00FF>100%!恭喜你,但是这条信息截图也无效233333</color>", false);
                }
            }
        }
        public void OnPlayerDeath(ref PlayerDeathEvent ev)
        {
            if(ev.Player.GetPlayerId() == hdjjsid)
            {
                hdjjs = null;
                hdjjsid = 0;
            }
            if(ev.Player.GetPlayerId() == tlid)
            {
                tlid = 0;
            }
            if(ev.Killer.GetRole()==RoleType.Scp173)
            {
                ev.Killer.SetGodMode(false);
            }
            if(ev.Player.GetPlayerId() == scp49jid)
            {
                scp49j = null;
                scp49jid = 0;
                Map.Broadcast("----[<color=#32CD32>SCP-49-J</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);

            }
            if (ev.Killer.GetRole() == RoleType.Scp049)
            {
                小僵尸id.Add(ev.Player.GetPlayerId());
                Remove492(ev.Player.GetPlayerId());
            }
            if (ev.Player.GetPlayerId() == Gears博士id)
            {
                Gears博士id = 0;
                Gears博士 = null;
                Setrank_new("", "white", ev.Player);

            }
            if (ev.Player.GetPlayerId() == fkyyzid)
            {
                fkyyz = null;
                fkyyzid = 0;
                fkyyzyes = false;
                bindljf = false;
                bindtys = false;
                bindjzsj = false;
                Setrank_new("", "white", ev.Player);

            }
            if (ev.Player.GetPlayerId() == scp550id)
            {
                Setrank_new("", "white", ev.Player);
                Map.Broadcast("----[<color=#32CD32>SCP550</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
                scp550id = 0;
                scp550yes = false;
                scp550 = null;
                scp550lv = 0;
                tssl = 0;

            }
            if(ev.Killer.GetPlayerId() == scp035id)
            {
                scp035item = ev.Killer.GetAllItems();
                scp035.SetRole(ev.Player.GetRole(), true);
                Coroutines.Add(Timing.RunCoroutine(SecondCounter24()));

            }
            if(ev.Player.GetPlayerId() == mzid)
            {
                mz = null;
                mzid = 0;
            }
            if (ev.Player.GetPlayerId() == jwhhkid)
            {

                Map.Broadcast("----[<color=#32CD32>九尾狐内鬼</color>]----\n<color=#FF0000>[已被消灭]</color>\n消灭者: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
                jwhng = null;
                jwhngwufashanghai = true;
                jwhngyes = false;
                jwhngshuachu = true;
                jwhngid = 0;
            }
            peaple = 0;
            if (scp_999.Contains(ev.Player.GetUserId()))
            {
                die = true;
                Setrank_new("", "", ev.Player);
                Log.Info("SCP99已死亡");
                scp_999.Clear();
                Map.Broadcast("----[<color=#32CD32>SCP999</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
            }
            foreach (ReferenceHub player in Player.GetHubs())
            {
                if (player.GetTeam() == Team.MTF)
                {
                    peaple += 1;
                }
            }
            if (sjqx == false)
            {
                if (peaple == 2)
                {
                    Map.Broadcast("<color=red>全村人的希望</color>\n<color=lime>你被强化了快上</color>", 5, false);
                    foreach (ReferenceHub player in Player.GetHubs())
                    {
                        if (player.GetTeam() == Team.MTF)
                        {
                            player.AddHealth(200);
                            player.AddItem(ItemType.SCP500);
                            sjqx = true;
                        }
                    }
                }

            }
            for (int i = 0; i <= 0x27; i++)
            {
                if (touxiang[i] == ev.Player.GetPlayerId())
                {
                    Log.Info(string.Concat(new object[] { "死亡投降玩家:", ev.Player.GetNickname(), " 死于:", ev.Killer.GetNickname(), " 作为:", ev.Killer.GetRole() }));
                    touxiang[i] = 0;
                }
            }

            ev.Player.Broadcast(7, "<color=lime>快乐老家 欢迎回家</color>", false);
            KillerID = ev.Killer.GetPlayerId();
            PlayerID = ev.Player.GetPlayerId();

            if ((scp650yes == true) && (ev.Killer.GetPlayerId() == scp650id))
            {

                scp650 = null;
                scp650id = 0;
                scp650yes = false;
                ev.Killer.SetGodMode(false);
                ev.Killer.Kill();
                ev.Killer.SetRole(RoleType.Spectator);

            }
            if (ev.Player.GetPlayerId() == jwhhkid)
            {
                jwhhkid = 0;
                jwhhk = null;
                Setrank_new("", "white", ev.Player);

            }
            if (ev.Player.GetPlayerId() == scp073id)
            {
                scp073 = null;
                scp073id = 0;
                Setrank_new("", "white", ev.Player);
                Map.Broadcast("----[<color=#32CD32>SCP073</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);

            }
            if (ev.Player.GetPlayerId() == scp076id)
            {
                scp076 = null;
                scp076id = 0;
                scp076yes = false;
                Setrank_new("", "white", ev.Player);
                Map.Broadcast("----[<color=#32CD32>SCP076</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);

            }
            if (ev.Player.GetPlayerId() == scp005aid)
            {
                scp005aid = 0;

            }
            if (ev.Player.GetPlayerId() == scp457id)
            {
                scp457 = null;
                scp457a = false;
                scp457die = true;
                scp457b = new Vector3();
                Setrank_new("", "white",  ev.Player);
                scp457id = 0;
                Map.Broadcast("----[<color=#32CD32>SCP457</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);

            }
            if (ev.Player.GetPlayerId() == xtdid)
            {
                xtd = null;
                xtdid = 0;
                Setrank_new("", "white",  xtd);

            }
            if ((qblcq2 == true) && (qblcq.GetPlayerId() == ev.Player.GetPlayerId()))
            {
                qblcq2 = false;
                qblcq = null;

            }
            if (scp682.Contains(ev.Player.GetUserId()))
            {
                scp682.Remove(ev.Player.GetUserId());
                Setrank_new(" ", "white",  ev.Player);
                Map.Broadcast("----[<color=#32CD32>SCP682</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);

            }
            if (scp939id == ev.Player.GetPlayerId())
            {
                Setrank_new(" ", "white", ev.Player);
                scp939id = 0;

            }
            if (ev.Player.GetPlayerId() == scp914mid)
            {
                scp914m = null;
                scp914mid = 0;
                Map.Broadcast("----[<color=#32CD32>SCP914-M</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);


            }
            if (ev.Player.GetPlayerId() == scpqblid2)
            {
                scpqblid2 = 0;
                Map.Broadcast("----[<color=#32CD32>SCP乔碧萝</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);

            }
            if (ev.Player.GetPlayerId() == scp181id)
            {
                scp181id = 0;
                Map.Broadcast("----[<color=#32CD32>SCP181</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
                Setrank_new("", "white", ev.Player);

            }
            if (ev.Player.GetPlayerId() == scp035id)
            {
                Map.Broadcast("----[<color=#32CD32>SCP035</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
                scp035 = null;
                scp035id = 0;
                scp035goout = false;
                scp035yes = false;
            }
            if (scp2006a.Contains(ev.Player.GetUserId()))
            {
                scp2006a.Clear();
                scp2006 = null;
                Map.Broadcast("----[<color=#32CD32>SCP2006</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
                Setrank_new("", "white",  ev.Player);

            }
            if (ev.Player.GetPlayerId() == cxkid)
            {
                cxkid = 0;
                cxk = null;
                cxkyes = false;
                Map.Broadcast("----[<color=#32CD32>SCP蔡徐坤</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
                Setrank_new("", "white", ev.Player);

            }
            if (ev.Player.GetPlayerId() == scp817id)
            {
                scp817id = 0;
                scp817 = null;
                scp817yes = false;
                Map.Broadcast("----[<color=#32CD32>SCP817</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
                Setrank_new("", "white", ev.Player);

            }
            if (ev.Player.GetPlayerId() == D9341id)
            {
                if (times >= 5)
                {
                    D9341 = null;
                    D9341id = 0;
                    D9341Item = null;
                    D9341yes = false;
                    D9341zb = new Vector3();
                    Setrank_new("", "white",  ev.Player);
                    Map.Broadcast("----[<color=#32CD32>D-9341</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);

                }
            }
            if (bpb2.Contains(ev.Player.GetPlayerId()))
            {
                bpb = false;
                bpb2.Clear();
                Setrank_new("", "white", ev.Player);

            }
            if (LLBS233.Contains(ev.Player.GetPlayerId()))
            {
                Map.Broadcast("<color=#FFFF33>Mr.fish:</color>\n装逼失败", 5, false);
                LLBS233.Remove(ev.Player.GetPlayerId());
                Setrank_new("", "white", ev.Player);

            }
            if (Dio2.Contains(ev.Player.GetUserId()))
            {
                Map.Broadcast("<color=#FFFF33>Dio:</color>\n装逼失败", 5, false);
                Dio2.Remove(ev.Player.GetUserId());
                Dio = null;
                Setrank_new("", "white", ev.Player);

            }
            if (scp1143id == ev.Player.GetPlayerId())
            {
                scp1143 = null;
                scp1143id = 0;
                scp1143a = false;
                Map.Broadcast("----[<color=#32CD32>SCP1143</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);

            }
            if (ylb2.Contains(ev.Player.GetUserId()))
            {
                Setrank_new("", "white", ev.Player);
                ylb = null;
                ylb1 = false;
                ylb2.Clear();

            }
            if (HDZHG2.Contains(ev.Player.GetUserId()))
            {
                HDZHG2.Remove(ev.Player.GetUserId());

            }
            if (ev.Player.GetRole() == RoleType.Scp173)
            {

                s173 = 2;
                if (KillerID == PlayerID)
                {
                    Map.Broadcast("----[<color=#32CD32>SCP173</color>]----\n<color=#FF0000>[收容成功]</color>\n原因: <color=#40E0D0>自杀或者被服务器日了</color>", 6, false);
                }
                else
                {
                    if (ev.Killer.GetUserId() == "76561198366416373@steam")
                    {
                        Map.Broadcast("----[<color=#32CD32>SCP173</color>]----\n<color=#FF0000>[收容成功]</color>\n花生你好弱啊 <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
                    }
                    else
                    {
                        Map.Broadcast("----[<color=#32CD32>SCP173</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
                    }

                }

            }
            if (ev.Player.GetRole() == RoleType.Scp049)
            {
                s049 = 2;
                if (KillerID == PlayerID)
                {
                    Map.Broadcast("----[<color=#32CD32>SCP049</color>]----\n<color=#FF0000>[收容成功]</color>\n原因: <color=#40E0D0>自杀或者被服务器日了</color>", 6, false);
                }
                else
                {
                    Map.Broadcast("----[<color=#32CD32>SCP049</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
                }

            }
            if (ev.Player.GetRole() == RoleType.Scp079)
            {
                Map.Broadcast("----[<color=#32CD32>SCP079</color>]----\n<color=#FF0000>[收容成功]</color>\n原因: <color=#40E0D0>核爆了</color>", 6, false);
                Setrank_new("SCP079 - 核爆了", "red", ev.Player);

            }
            if (ev.Player.GetRole() == RoleType.Scp096)
            {
                s096 = 2;
                if (KillerID == PlayerID)
                {
                    Map.Broadcast("----[<color=#32CD32>SCP096</color>]----\n<color=#FF0000>[收容成功]</color>\n原因: <color=#40E0D0>自杀或者被服务器日了</color>", 6, false);
                }
                else
                {
                    Map.Broadcast("----[<color=#32CD32>SCP096</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
                }

            }
            if (ev.Player.GetRole() == RoleType.Scp93953)
            {
                s939_53 = 2;
                if (KillerID == PlayerID)
                {
                    Map.Broadcast("----[<color=#32CD32>SCP939_53</color>]----\n<color=#FF0000>[收容成功]</color>\n原因: <color=#40E0D0>自杀或者被服务器日了</color>", 6, false);
                }
                else
                {
                    Map.Broadcast("----[<color=#32CD32>SCP939_53</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
                }

            }
            if (ev.Player.GetRole() == RoleType.Scp93989)
            {
                s939_89 = 2;
                if (KillerID == PlayerID)
                {
                    Map.Broadcast("----[<color=#32CD32>SCP939_89</color>]----\n<color=#FF0000>[收容成功]</color>\n原因: <color=#40E0D0>自杀或者被服务器日了</color>", 6, false);
                }
                else
                {
                    Map.Broadcast("----[<color=#32CD32>SCP939_89</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
                }

            }
            if (ev.Player.GetRole() == RoleType.Scp106)
            {
                s106 = 2;
                if (KillerID == PlayerID)
                {
                    Map.Broadcast("----[<color=#32CD32>SCP106</color>]----\n<color=#FF0000>[收容成功]</color>\n原因: <color=#40E0D0>自杀或者被服务器日了</color>", 6, false);
                }
                else
                {
                    Map.Broadcast("----[<color=#32CD32>SCP106</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + ev.Killer.GetNickname() + "</color>", 6, false);
                }
            }
        }
        public void OnThrowGrenade(ref GrenadeThrownEvent ev)
        {

        }
        public void OnMedicalItem(MedicalItemEvent ev)
        {
            if (ev.Player.GetUserId() == jklid)
            {
                ev.Allow = false;
                ev.Player.AddHealth(500);
                jklid = null;
            }
            if(ev.Player.GetPlayerId() == scp457id)
            {
                scp457health = ev.Player.GetHealth();
                Coroutines.Add(Timing.RunCoroutine(Scp457helth()));
            }
            
        }
        private IEnumerator<float> Scp457helth()
        {
            yield return Timing.WaitForSeconds(10f);
            scp457.SetHealth(scp457health);
        }

        public void OnTeamRespawn(ref TeamRespawnEvent ev)
        {
            if (ev.IsChaos == true)
            {
                player22 = ev.ToRespawn;
                times2 = 1;
                foreach (ReferenceHub p in player22)
                {
                    hd.Add(p.GetUserId());
                }
                
            }
            if (ev.IsChaos == false)
            {
                player22 = ev.ToRespawn;
                tiems = 0;
                foreach (ReferenceHub p in player22)
                {
                    jw.Add(p.GetPlayerId());
                }
                Coroutines.Add(Timing.RunCoroutine(SetNineFox()));
            }

        }
        private IEnumerator<float> Ljfsx()
        {
            yield return Timing.WaitForSeconds(10f);
            ljfwj.Clear();
            ljfuse = false;
        }
        private IEnumerator<float> Lxsx()
        {
            yield return Timing.WaitForSeconds(10f);
            lxyes = false;
        }
        
        private IEnumerator<float> Jzsjsx()
        {
            yield return Timing.WaitForSeconds(5f);
            jzsjuse = false;
        }
        private IEnumerator<float> Rhdsx()
        {
            yield return Timing.WaitForSeconds(60f);
            rhdyes = false;
        }
        private IEnumerator<float> Rhd()
        {
            for (; ; )
            {
                
                fkyyz.Broadcast(3, "距离" + Vector3.Distance(fkyyz.GetPosition(), rhdzzwj.GetPosition()));
                if(rhdyes == false)
                {
                    break;
                }
                yield return Timing.WaitForSeconds(3f);
            }
        }
        private IEnumerator<float> Tyssx()
        {
            yield return Timing.WaitForSeconds(5f);
            tysuse = false;
        }

        public void OnConsoleCommand(ConsoleCommandEvent ev)
        {
            int num = 0;
            int num2 = 0;
            char[] separator = new char[] { ' ' };
            string[] strArray = ev.Command.ToLower().Split(separator);
            if(ev.Command == "badappledonotuse")
            {
                Coroutines.Add(Timing.RunCoroutine(Badapple("txt")));
            }
            if (ev.Command == "xiangjiaojundonotuse")
            {
                Coroutines.Add(Timing.RunCoroutine(Badapple("xiangjiaojuntxt")));
            }
            if (ev.Command == "cxkdonotuse")
            {
                Coroutines.Add(Timing.RunCoroutine(Badapple("cxktxt")));
            }
            if(ev.Command == "jlck")
            {
                时间 = "";
                地点 = "";
                人物 = "";
                事件 = "";
                句子 = "";
                缺少 = "";
            }
            if(ev.Command.Contains("jl"))
            {
                if (时间 == "")
                {
                    try
                    {
                        时间 = strArray[1];
                    }
                    catch
                    {
                        Log.Info("nope");
                    }
                }
                else if (地点 == "")
                {
                    try
                    {
                        地点 = strArray[1];
                    }
                    catch
                    {
                        Log.Info("nope");
                    }
                }
                else if (人物 == "")
                {
                    try
                    {
                        人物 = strArray[1];
                    }
                    catch
                    {
                        Log.Info("nope");
                    }
                }
                else if (事件 == "")
                {
                    try
                    {
                        事件 = strArray[1];
                    }
                    catch
                    {
                        Log.Info("nope");
                    }
                }
                foreach (ReferenceHub referenceHub in Player.GetHubs())
                {
                    if (referenceHub.GetRole() == RoleType.Spectator)
                    {
                        句子 = 时间 + 地点 + 人物 + 事件;
                        if (时间 == "")
                        {
                            缺少 = "时间 输入.jl 内容补充内容";
                        }
                        else if (地点 == "")
                        {
                            缺少 = "地点 输入.jl 内容补充内容";
                        }
                        else if (人物 == "")
                        {
                            缺少 = "人物 输入.jl 内容补充内容";
                        }
                        else if (事件 == "")
                        {
                            缺少 = "事件 输入.jl 内容补充内容";
                        }
                        else
                        {
                            缺少 = "输入.jlck开启下一回合";
                        }
                        referenceHub.Broadcast(5, "当前句子" + 句子 + "\n" + "当前缺少" + 缺少);
                    }
                }
            }
            if (ev.Player.GetPlayerId() == jwhngid)
            {
                if(ev.Command == "wz")
                {
                    item = ev.Player.GetAllItems();
                    health = ev.Player.GetHealth();
                    if (ev.Player.GetRole() == RoleType.ChaosInsurgency)
                    {
                        ev.Player.SetRole(RoleType.NtfCadet, true);
                    }
                    else if (ev.Player.GetRole() == RoleType.NtfCadet)
                    {
                        ev.Player.SetRole(RoleType.ChaosInsurgency, true);
                    }

                    Coroutines.Add(Timing.RunCoroutine(SecondCounter25()));
                }

            }
            if((ev.Player.GetPlayerId() == fkyyzid)&&(ev.Player.GetRole() == RoleType.Tutorial))
            {
                if(ev.Command == "help")
                {
                    ev.Player.SendConsoleMessage("你当前有" + fkyyzcardint + "张符卡", "green");
                    ev.Player.SendConsoleMessage("此人物为测试阶段可能含有很多bug", "green");
                    ev.Player.SendConsoleMessage("「灵击符」输入.ljf使用效果周围30m人无法移动和攻击10s中 你也无法攻击但是可以移动\n输入.bindljf则可以在背包生成\n输入.debindljf即可取消绑定", "green");
                    ev.Player.SendConsoleMessage("「静止时计」输入.jzsj时间停止5s 你也无法攻击但是可以移动\n输入.bindjzsj则可以在背包生成\n输入.debindjzsj即可取消绑定", "green");
                    ev.Player.SendConsoleMessage("「替身娃娃」输入.tsww 可以获得护盾 别问我为什么没有绑定功能233", "green");
                    ev.Player.SendConsoleMessage("「特别定制的太阳伞」输入.tys 可以获得5s钟抗性和反伤\n输入.bindtys在背包生成一个大黄卡\n输入.debindtys即可取消绑定", "green");
                    ev.Player.SendConsoleMessage("「人魂灯」输入.rhd [玩家编号]\n玩家编号可以通过.list获取\n效果：被选择的人的位置会对你显示", "green");
                    ev.Player.SendConsoleMessage("「左扇」输入.zs 降低自身攻击力获取高防御30s(未做完请勿使用）", "green");
                    ev.Player.SendConsoleMessage("「伊吹瓢」输入.ycp 获取两张符卡(未做完请勿使用)", "green");
                    ev.Player.SendConsoleMessage("「天狗团扇」输入.tgts 获取移速提升", "green");
                    ev.Player.SendConsoleMessage("「龙玉之羽衣」输入.yy 在使用后10s如果你被攻击 攻击者被定身 且你获得无敌(未做完请勿使用)", "green");
                    ev.Player.SendConsoleMessage("「病气平御护符」输入.bqpyhf 在使用后 恢复随机100-150血量", "green");
                    ev.Player.SendConsoleMessage("「龙星」输入.lx 在使用后 短时间增加自身攻击力", "green");
                    ev.Player.SendConsoleMessage("「制御棒」输入.zyb 在使用后 永久增加自身攻击力 降低防御力", "green");


                }

                if (ev.Command == "bindljf")
                {
                    if (ev.Player.GetAllItems().Count == 8)
                    {
                        ev.ReturnMessage = "背包无多余位置，绑定失败";
                    }
                    else
                    {
                        ev.Player.AddItem(ItemType.KeycardJanitor);
                        ev.Player.SendConsoleMessage("「灵击符」绑定完成 丢下清洁工卡即可使用", "green");
                        bindljf = true;
                    }
                }
                if(ev.Command == "debindljf")
                {
                    bindljf = false;
                    ev.Player.SendConsoleMessage("「灵击符」解除绑定成功", "green");

                }
                if (ev.Command == "bindjzsj")
                {
                    if (ev.Player.GetAllItems().Count == 8)
                    {
                        ev.ReturnMessage = "背包无多余位置，绑定失败";
                    }
                    else
                    {
                        ev.Player.AddItem(ItemType.KeycardScientist);
                        ev.Player.SendConsoleMessage("「静止时计」绑定完成 丢下科学家卡即可使用", "green");
                        bindjzsj = true;
                    }
                }
                if (ev.Command == "debindljf")
                {
                    bindjzsj = false;
                    ev.Player.SendConsoleMessage("「静止时计」解除绑定成功", "green");
                }
                if (ev.Command == "bindtys")
                {
                    if (ev.Player.GetAllItems().Count == 8)
                    {
                        ev.ReturnMessage = "背包无多余位置，绑定失败";
                    }
                    else
                    {
                        ev.Player.AddItem(ItemType.KeycardScientistMajor);
                        ev.Player.SendConsoleMessage("「特别定制的太阳伞」绑定完成 丢下大科学家卡即可使用", "green");
                        bindtys = true;
                    }
                }
                if (ev.Command == "debindtys")
                {
                    bindtys = false;
                    ev.Player.SendConsoleMessage("「特别定制的太阳伞」解除绑定成功", "green");
                }
                if (fkyyzcardint > 0 )
                {
                    if (ev.Command == "ljf")
                    {
                        Vector3 pos2 = ev.Player.GetPosition();
                        float numx1 = pos2.x + 30;
                        float num3 = pos2.y + 30;
                        float num4 = pos2.z + 30;
                        float num5 = pos2.x - 30;
                        float num6 = pos2.y - 30;
                        float num7 = pos2.z - 30;
                        fkyyzcardint--;
                        foreach (ReferenceHub player3 in Player.GetHubs())
                        {
                            if ((player3.GetPosition().x <= numx1) && (player3.GetPosition().x >= num5) && (player3.GetPosition().y <= num3) && (player3.GetPosition().y >= num6) && ((player3.GetPosition().z <= num4) && (player3.GetPosition().z >= num7)))
                            {
                                ljfwj.Add(player3);
                                ljfuse = true;
                                player3.Broadcast(5, "「灵击符」十秒内无法行动", false);
                                Coroutines.Add(Timing.RunCoroutine(Ljfsx()));
                                
                            }
                        }

                    }
                    if(ev.Command == "jzsj")
                    {
                        Coroutines.Add(Timing.RunCoroutine(Jzsjsx()));
                        jzsjuse = true;
                        Map.Broadcast("「静止时计」效果时间停止5s",5,false);
                        fkyyzcardint--;
                    }
                    if(ev.Command == "tsww")
                    {
                        ev.Player.AddAdrenalineHealth(100);
                        fkyyzcardint--;
                    }
                    if(ev.Command == "tys")
                    {
                        Coroutines.Add(Timing.RunCoroutine(Tyssx()));

                        ev.Player.Broadcast(5, "你已获得5s钟反伤", false);
                        tysuse = true;
                        fkyyzcardint--;

                    }
                    if (ev.Command == "bqpyhf")
                    {
                        int num4 = new System.Random().Next(100, 150);
                        ev.Player.AddHealth(num4);
                        ev.Player.SendConsoleMessage("「病气平御护符」使用成功回血"+num4, "green");
                        fkyyzcardint--;
                    }
                    if(ev.Command.Contains("rhd"))
                    {
                        foreach(ReferenceHub referenceHub in Player.GetHubs())
                        {
                            try
                            {
                                if (referenceHub.GetPlayerId() == int.Parse(strArray[1]))
                                {
                                    ev.Player.SendConsoleMessage("「人魂灯」使用成功追踪玩家" + referenceHub.GetNickname(), "green");
                                    rhdzzwj = referenceHub;
                                    rhdyes = true;
                                    fkyyzcardint--;
                                    Coroutines.Add(Timing.RunCoroutine(Rhdsx()));

                                }
                            }
                            catch
                            {
                                ev.Player.SendConsoleMessage("「人魂灯」使用失败 来自插件抛出异常 可能是没有填写玩家id", "green");
                            }
                        }

                    }
                    if (ev.Command == "zyb")
                    {
                        ev.Player.SendConsoleMessage("「制御棒」使用成功", "green");
                        fkyyzcardint--;
                        zybuse = true;
                    }
                    if (ev.Command == "tgts")
                    {
                        ev.Player.SendConsoleMessage("「天狗团扇」使用成功", "green");
                        fkyyzcardint--;
                        ev.Player.AddItem(ItemType.SCP207);
                    }
                    if (ev.Command == "lx")
                    {
                        Coroutines.Add(Timing.RunCoroutine(Lxsx()));
                        lxyes = true;
                        ev.Player.SendConsoleMessage("「龙星」使用成功", "green");

                        fkyyzcardint--;
                    }
                }

            }
            if(ev.Player.GetPlayerId() == tuolikadianid)
            {
                if (ev.Command.Contains("tlkd"))
                {
                    ev.Player.SetPosition(Map.GetRandomSpawnPoint(ev.Player.GetRole()));
                    tuolikadianid = 0;
                }
            }

            
            foreach (ReferenceHub player in Player.GetHubs())
            {
                if (player.GetRole() == RoleType.ChaosInsurgency)
                {
                    num++;
                }
                if (player.GetTeam() == Team.MTF)
                {
                    num2++;
                }
            }
            if (ev.Player.GetRole() == RoleType.Scp079)
            {
                if (choise == false)
                {
                    if (ev.Command.Contains("scp"))
                    {
                        choise = true;
                        foreach (ReferenceHub player in Player.GetHubs())
                        {
                            if (player.GetRole() == RoleType.Scp079)
                            {
                                player.SetRank("SCP079 - 帮助SCP", "aqua", true);
                            }
                        }
                        scp79 = true;
                        Map.Broadcast("<color=#FFC0CB>---[SCP079]---</color>\n<color=aqua>人类感受恐惧吧 本局SCP079选择帮助SCP</color>\n<color=aqua>SCP不会受到电网伤害(人形scp除外)</color>", 10,  false);
                    }
                    if (ev.Command.Contains("h"))
                    {
                        foreach (ReferenceHub player in Player.GetHubs())
                        {
                            if (player.GetRole() == RoleType.Scp079)
                            {
                                player.SetRank("SCP079 - 最大电力:130 | 电力恢复:3AP/s   帮助人类", "aqua", true);
                            }
                        }
                        h = true;
                        Setrank_new("SCP079 - 最大电力:130 | 电力恢复:3AP/s   帮助人类", "aqua", ev.Player);
                        choise = true;
                        Map.Broadcast("<color=#FFC0CB>---[SCP079]---</color>\n<color=aqua>SCP没想到吧我是25仔 本局SCP079选择帮助人类</color>\n<color=aqua>人类不会受到电网伤害</color>", 10,  false);
                        foreach (ReferenceHub p in Player.GetHubs())
                        {
                            if (p.GetTeam() == Team.SCP)
                            {
                                if (p.GetRole() != RoleType.Scp106)
                                {
                                    p.AddHealth(3000);
                                }
                            }
                        }
                    }
                }
            }
            if (ev.Command.Contains("steal") && (ev.Player.GetPlayerId() == xtd.GetPlayerId()) && (stealcd == false))
            {
                stealcd = true;
                int num4 = new System.Random().Next(1, 10);
                if (num4 == 1)
                {
                    ev.Player.AddItem(ItemType.Coin);
                }
                if (num4 == 2)
                {
                    ev.Player.AddItem(ItemType.KeycardNTFCommander);

                }
                if (num4 == 3)
                {
                    ev.Player.AddItem(ItemType.GunE11SR); ;
                }
                if (num4 == 4)
                {
                    ev.Player.AddItem(ItemType.GunUSP);
                }
                if (num4 == 5)
                {
                    ev.Player.AddItem(ItemType.SCP500);
                }
                if (num4 == 6)
                {
                    ev.Player.AddItem(ItemType.KeycardO5);
                }
                if (num4 > 6)
                {
                    ev.Player.SendConsoleMessage("什么都没偷到", "green");
                }
            }
            if (ev.Player.GetUserId() == xywjid)
            {
                if (ev.Command.Contains("s173"))
                {
                    xywj.SetRole(RoleType.Scp173);
                    xywj = null;
                    xywjid = null;
                }
                if (ev.Command.Contains("s106"))
                {
                    xywj.SetRole(RoleType.Scp106);
                    xywj = null;
                    xywjid = null;
                }
                if (ev.Command.Contains("sD"))
                {
                    xywj.SetRole(RoleType.ClassD);
                    xywj = null;
                    xywjid = null;
                }
                if (ev.Command.Contains("sS"))
                {
                    xywj.SetRole(RoleType.Scientist);
                    xywj = null;
                    xywjid = null;
                }
                if (ev.Command.Contains("sG"))
                {

                    xywj = null;
                    xywjid = null;
                    xywj.Kill();
                    xywj.SetRole(RoleType.FacilityGuard);
                }
                if (ev.Command.Contains("s96"))
                {
                    xywj = null;
                    xywjid = null;
                    xywj.Kill();
                    xywj.SetRole(RoleType.Scp096);
                }
                if ((scp650yes == true) && (ev.Player.GetPlayerId() == scp650id))
                {
                    scp650 = null;
                    scp650id = 0;
                    scp650yes = false;
                    Setrank_new("", "white", ev.Player);
                    Map.Broadcast("----[<color=#32CD32>[SCP650]</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + "自选人物了" + "</color>", 6, false);

                }
                if (ev.Player.GetPlayerId() == scp076id)
                {
                    scp076 = null;
                    scp076id = 0;
                    scp076yes = false;
                    Setrank_new("", "white", ev.Player);
                    Map.Broadcast("----[<color=#32CD32>SCP076</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + "自选人物了" + "</color>", 6, false);

                }
                
            }

            if (ev.Command.Contains("dk"))
            {
                if (hrss == true)
                {
                    jwhhk.SetRole(RoleType.NtfScientist);
                    jwhhk.SetPosition(hkzb);
                    hktime = 0;
                    hrss = false;
                }
            }

            if (ev.Command.Contains("hk"))
            {
                if ((jwhhkid == ev.Player.GetPlayerId()) && (hrss == false))
                {
                    hrss = true;
                    hkzb = ev.Player.GetPosition();
                    ev.Player.SetRole(RoleType.Scp079);
                    ev.Player.Broadcast(10, "<color=lime>输入.dk退出黑客模式</color>", false);

                }
            }

            if (ev.Command.Contains("tx")&&(ev.Player.GetPlayerId()!= scp035id) && ((ev.Player.GetRole() == RoleType.ClassD) && (Dio2.Contains(ev.Player.GetUserId()) == false) || (ev.Player.GetRole() == RoleType.Scientist)))
            {
                int playerId = ev.Player.GetPlayerId();
                if ((ev.Player.GetRole() == RoleType.ClassD) && (num == 0))
                {
                    touxiang[round] = playerId;
                    ev.Player.Broadcast(10, "<color=#FF00FF>你已经进入投降模式</color>无法取消\n当你逃出的时候<color=#00FF7F>自动变为相反阵营</color>", false);
                    Setrank_new("(" + ev.Player.GetPlayerId() + ") 投降人员", "default", ev.Player);
                    round++;
                }
                else if ((ev.Player.GetRole() == RoleType.ClassD) && (num > 0))
                {
                    ev.Player.Broadcast(10, "<color=#FF00FF>你无法进入投降模式</color>\n因为场上有<color=#00FF7F>混沌</color>", false);
                }
                if ((ev.Player.GetRole() == RoleType.Scientist) && (num2 == 0))
                {
                    touxiang[round] = playerId;
                    ev.Player.Broadcast(10, "<color=#FF00FF>你已经进入投降模式</color>无法取消\n当你逃出的时候<color=#00FF7F>自动变为相反阵营</color>", false);
                    Setrank_new("投降人员", "default", ev.Player);
                    round++;
                }
                else if ((ev.Player.GetRole() == RoleType.Scientist) && (num2 > 0))
                {
                    ev.Player.Broadcast(10, "<color=#FF00FF>你无法进入投降模式</color>\n因为场上有<color=#00FF7F>MTF</color>", false);
                }
            }
            if (ev.Command.Contains("pos"))
            {
                Vector3 position = ev.Player.GetPosition();
                object[] objArray1 = new object[] { position.x, "|", position.y, "|", position.z };
                ev.ReturnMessage = string.Concat(objArray1) ?? "";
            }
            if (strArray[0] == "c")
            {
                if (strArray.Length == 1)
                {
                    ev.Player.SendConsoleMessage("请输入内容", "yellow");
                }
                if (strArray.Length == 2)
                {
                    ev.Player.SendConsoleMessage("发送成功", "yellow");
                    if (ev.Player.GetRole() == RoleType.Spectator)
                    {
                        foreach (ReferenceHub player in Player.GetHubs())
                        {
                            if (player.GetRole() == RoleType.Spectator)
                            {
                                player.Broadcast(5, "[玩家]" + ev.Player.GetNickname() + strArray[1], false);
                            }
                        }
                    }
                    if (ev.Player.GetTeam() == Team.SCP)
                    {
                        foreach (ReferenceHub player in Player.GetHubs())
                        {
                            if (player.GetTeam() == Team.SCP)
                            {
                                player.Broadcast(5, "[玩家]" + ev.Player.GetNickname() + strArray[1], false);
                            }
                        }
                    }
                    if (ev.Player.GetTeam() == Team.MTF)
                    {
                        foreach (ReferenceHub player in Player.GetHubs())
                        {
                            if (player.GetTeam() == Team.MTF)
                            {
                                player.Broadcast(5, "[玩家]" + ev.Player.GetNickname() + strArray[1], false);
                            }
                        }
                    }
                }
            }
            if (strArray[0] == "xfuckyou")
            {
                Vector3 vector = new Vector3(ev.Player.GetPosition().x + 3, ev.Player.GetPosition().y, ev.Player.GetPosition().z);

                ev.Player.SetPosition(vector);
            }
            if (strArray[0] == "yfuckyou")
            {
                Vector3 vector = new Vector3(ev.Player.GetPosition().x, ev.Player.GetPosition().y + 3, ev.Player.GetPosition().z);

                ev.Player.SetPosition(vector);
            }
            if (strArray[0] == "zfuckyou")
            {
                Vector3 vector = new Vector3(ev.Player.GetPosition().x, ev.Player.GetPosition().y, ev.Player.GetPosition().z + 3);

                ev.Player.SetPosition(vector);
            }
            if ((ev.Player.GetRole() == RoleType.NtfCommander) && (strArray[0] == "bc"))
            {
                if (strArray.Length == 1)
                {
                    ev.Player.SendConsoleMessage("\n指挥鱼命令使用教程:\n\n.bc [内容]\n\n内容会全图发送给予所有九尾鱼阵营玩家", "yellow");
                }
                else if ((strArray.Length == 2) && !coldbc)
                {
                    coldbc = true;
                    foreach (ReferenceHub player5 in Player.GetHubs())
                    {
                        if (player5.GetTeam() == Team.MTF)
                        {
                            player5.ClearBroadcasts();
                            player5.Broadcast(6, "<color=#4682B4>[来自指挥鱼的信息]</color>\n" + strArray[1], false);
                        }
                    }

                }
            }
            if (strArray[0] == "f")
            {
                Vector3 pos = scpqbl3.GetPosition();
                float pos2 = pos.x + 3;
                float pos3 = pos.y + 3;
                float pos4 = pos.z + 3;
                float pos5 = pos.x - 3;
                float pos6 = pos.y - 3;
                float pos7 = pos.z - 3;
                ReferenceHub player = ev.Player;
                if (qblcq2 == true)
                {
                    qblcq2 = false;
                }
                else if ((player.GetPosition().x <= pos2) && (player.GetPosition().x >= pos5) && (player.GetPosition().y <= pos3) && (player.GetPosition().y >= pos6) && ((player.GetPosition().z <= pos4) && (player.GetPosition().z >= pos7)))
                {
                    Map.Broadcast(ev.Player.GetNickname() + "已经登上坦克", 5, false);
                    qblcq = ev.Player;
                    qblcq2 = true;
                }



            }
            if ((ev.Player.GetRole() == RoleType.NtfCommander) && (strArray[0] == "tb"))
            {
                if (strArray.Length == 1)
                {
                    ev.Player.SendConsoleMessage("\n提拔使用教程:\n\n.tb [编号]\n\n可以将九尾狐新兵提拔为 九尾狐士官 300秒1个人", "yellow");
                }
                else if ((strArray.Length == 2) && !coldtb)
                {
                    coldtb = true;

                    int num4 = int.Parse(strArray[1]);
                    foreach (ReferenceHub player2 in Player.GetHubs())
                    {
                        if ((player2.GetPlayerId() == num4) && (player2.GetRole() == RoleType.NtfCadet))
                        {
                            ev.Player.SendConsoleMessage("提拔成功", "yellow");
                            player2.SetRole(RoleType.NtfLieutenant);
                            player2.Broadcast(5, "你表现得超级nice被指挥官提拔了", false);
                        }
                    }

                }
            }
            if ((HDZHG2.Contains(ev.Player.GetUserId())) && (strArray[0] == "bc"))
            {
                if (strArray.Length == 1)
                {
                    ev.Player.SendConsoleMessage("\n混沌指挥鱼命令使用教程:\n\n.bc [内容]\n\n内容会全图发送给予所有九尾鱼阵营玩家", "yellow");
                }
                else if ((strArray.Length == 2))
                {
                    foreach (ReferenceHub player5 in Player.GetHubs())
                    {
                        if (player5.GetTeam() == Team.CHI)
                        {
                            player5.ClearBroadcasts();
                            player5.Broadcast(6, "<color=#4682B4>[来自混沌指挥鱼的信息]</color>\n" + strArray[1], false);
                        }
                    }

                }
            }
            if ((strArray[0] == "list"))
            {
                if (strArray.Length == 1)
                {
                    ev.Player.SendConsoleMessage("全部id", "yellow");
                    foreach (ReferenceHub player5 in Player.GetHubs())
                    {
                        ev.Player.SendConsoleMessage("玩家名字:" + player5.GetNickname() + "     玩家编号:" + player5.GetPlayerId(), "yellow");
                    }
                    ev.Player.SendConsoleMessage("获取完毕", "yellow");
                }
            }
            if ((strArray[0] == "cz"))
            {
                if (strArray.Length == 1)
                {
                    ev.Player.SendConsoleMessage("重新做人指令帮助 可以让指定的混沌变成DD重新来过", "yellow");

                }
                if (strArray.Length == 2)
                {
                    int num4 = int.Parse(strArray[1]);
                    foreach (ReferenceHub player2 in Player.GetHubs())
                    {
                        if ((player2.GetPlayerId() == num4) && (player2.GetTeam() == Team.CHI) && (!HDZHG2.Contains(player2.GetUserId())))
                        {
                            ev.Player.SendConsoleMessage("执行完成", "yellow");
                            player2.SetRole(RoleType.ClassD);
                            player2.Broadcast(5, "你因为惹怒了混沌指挥官被开除成DD", false);
                        }
                    }
                }
            }
            if ((strArray[0] == "help"))
            {
                if (strArray.Length == 1)
                {
                    if (HDZHG2.Contains(ev.Player.GetUserId()))
                    {
                        ev.Player.SendConsoleMessage("混沌指挥官使用教程\n.bc + [内容]把内容广播给全体混沌\n.cz +[玩家编号]把玩家开除成D级", "green");
                    }
                    if (ev.Player.GetRole() == RoleType.NtfCommander)
                    {
                        ev.Player.SendConsoleMessage("九尾狐指挥官使用教程\n.bc + [内容]把内容广播给全体九尾狐\n.tb +[玩家编号]把玩家升级", "green");
                    }

                }
            }
        }
        public void PMD()
        {
        qwq1:

            if (roundstart == false)
            {

                for (int i = 0; i < player233.Count; i++)
                {
                    if (roundstart == false)
                    {
                        if (player233[i].GetUserId() != "76561198284755079@steam"&& player233[i].GetUserId() != "76561198389200613@steam")
                        {
                            player233[i].SetRank("称号预留位置", "red", true);
                        }

                    }
                }
                Thread.Sleep(5000);
                for (int i = 0; i < player233.Count; i++)
                {

                    if (roundstart == false)
                    {
                        if (player233[i].GetUserId() != "76561198284755079@steam" && player233[i].GetUserId() != "76561198389200613@steam")
                        {
                            player233[i].SetRank("欢迎加入这个破服务器:1021889243 | 请看标题", "red", true);
                        }
                    }

                }
                Thread.Sleep(5000);
                for (int i = 0; i < player233.Count; i++)
                {
                    if (roundstart == false)
                    {
                        if (player233[i].GetUserId() != "76561198284755079@steam" && player233[i].GetUserId() != "76561198389200613@steam")
                        {
                            player233[i].SetRank("欢迎加入这个破服务器:1021889243 | 请看标题", "yellow", true);
                        }
                    }

                }
                Thread.Sleep(5000);
                for (int i = 0; i < player233.Count; i++)
                {
                    if (roundstart == false)
                    {
                        if (player233[i].GetUserId() != "76561198284755079@steam" && player233[i].GetUserId() != "76561198389200613@steam")
                        {
                            player233[i].SetRank("欢迎加入这个破服务器:1021889243 | 请看标题", "green", true);
                        }
                    }
                }
                Thread.Sleep(5000);
                for (int i = 0; i < player233.Count; i++)
                {
                    if (roundstart == false)
                    {
                        if (player233[i].GetUserId() != "76561198284755079@steam" && player233[i].GetUserId() != "76561198389200613@steam")
                        {
                            player233[i].SetRank("欢迎加入这个破服务器:1021889243 | 请看标题", "pink", true);
                        }
                    }

                }
                Thread.Sleep(5000);
            }
            else
            {
                pmd.Abort();
            }
            goto qwq1;
        }
        public void OnPocketDimDeath(PocketDimDeathEvent ev)
        {
            if (scp_999.Contains(ev.Player.GetUserId()))
            {
                ev.Allow = false;
            }
            if (ev.Player.GetPlayerId() == scp457id)
            {
                ev.Allow = false;
            }
            if (ev.Player.GetPlayerId() == scp181id)
            {
                ev.Allow = false;
            }
        }
        public void OnCheckEscape(ref CheckEscapeEvent ev)
        {
            if(scp035id == ev.Player.GetPlayerId())
            {
                ev.Allow = false;
                Map.Broadcast("<color=#red>警告！！！[SCP-035]已经逃出设施 请尽快消灭</color>", 10, false);
                scp035goout = true;
            }

            if (LLBS233.Contains(ev.Player.GetPlayerId()))
            {
                ev.Allow = false;
            }
            foreach (ReferenceHub player in Player.GetHubs())
            {
                if (player.GetRole() == RoleType.ChaosInsurgency)
                {
                    chaos++;
                }
                if (player.GetTeam() == Team.MTF)
                {
                    mtf++;
                }
            }
            Log.Info("混沌人数:" + chaos);
            Log.Info("MTF人数:" + mtf);
            foreach (int num2 in touxiang)
            {
                if (num2 == ev.Player.GetPlayerId())
                {
                    Log.Info("投降玩家是:" + ev.Player.GetNickname());
                }
                if (((num2 == ev.Player.GetPlayerId()) && (ev.Player.GetRole() == RoleType.ClassD)) && (chaos == 0))
                {
                    Log.Info("玩家即将变为NTF学员");
                    Log.Info("玩家名:" + ev.Player.GetNickname());
                    ev.Player.SetRole(RoleType.NtfCadet);
                    for (int i = 0; i <= 100; i++)
                    {
                        if (touxiang[i] == ev.Player.GetPlayerId())
                        {
                            touxiang[i] = 0;
                        }
                    }
                    chaos = 0;
                    mtf = 0;
                    return;
                }
                if (((num2 == ev.Player.GetPlayerId()) && (ev.Player.GetRole() == RoleType.Scientist)) && (mtf == 0))
                {
                    Log.Info("玩家即将变为混沌");
                    Log.Info("玩家名:" + ev.Player.GetNickname());
                    ev.Player.SetRole(RoleType.ChaosInsurgency);
                    for (int i = 0; i <= 100; i++)
                    {
                        if (touxiang[i] == ev.Player.GetPlayerId())
                        {
                            touxiang[i] = 0;
                        }
                    }
                    chaos = 0;
                    mtf = 0;
                    return;
                }
            }
            chaos = 0;
            mtf = 0;
        }
        public void OnDoorInteract(ref DoorInteractionEvent ev)
        {
            if (door2.Contains(ev.Door) && (jljy2.Contains(ev.Player.GetUserId()) == false))
            {
                ev.Player.AddHealth(-50);
                ev.Player.Broadcast(5, "吉良吉影为你点赞", false);
                door2.Remove(ev.Door);

            }
            System.Random num111 = new System.Random();
            if ((num111.Next(1, 1000) >= 999))
            {             
                foreach (GameObject door in GameObject.FindGameObjectsWithTag("Door"))
                {
                    doorlist.Add(door);
                }

                System.Random random = new System.Random();
                GameObject doorchoice = doorlist[random.Next(doorlist.Count)];
                ev.Player.SetPosition(new Vector3(doorchoice.transform.position.x, doorchoice.transform.position.y + (float)1.5, doorchoice.transform.position.z));
                ev.Player.ClearBroadcasts();
                ev.Player.Broadcast(5, "----[<color=#32CD32>SCP247</color>]----\n<color=#FF0000>你碰到了随机门以被传送\n如果你被卡住 使用指令.tlkd </color>", false);
                doorlist.Clear();
                tuolikadianid = ev.Player.GetPlayerId();
            }

            // foreach (GameObject door in GameObject.FindGameObjectsWithTag("Door"))
            //{
            //  System.Random num111 = new System.Random();
            //if ((num111.Next(1, 301) >= 299) && (deadtimer <= 1800))
            //{
            //
            //  ev.Player.SetPosition(new Vector3(door.transform.position.x, door.transform.position.y + (float)1.5, door.transform.position.z));
            //ev.Player.ClearBroadcasts();
            //ev.Player.Broadcast(5, "----[<color=#32CD32>SCP247</color>]----\n<color=#FF0000>你碰到了随机门以被传送</color>", false);

            //}
            //}



            if (bhsx == true)
            {
                if (new System.Random().Next(0, 100) >= 97)
                {
                    ev.Allow = false;
                }
            }
            if ((ev.Player.GetRole() == RoleType.Scp096) && (new System.Random().Next(1, 100) <= 3))
            {
                ev.Allow = true;
            }
            if ((ev.Door.DoorName == "NUKE_SURFACE") && (ev.Player.inventory.GetItemInHand().id == ItemType.KeycardNTFCommander) || (ev.Player.inventory.GetItemInHand().id == ItemType.KeycardChaosInsurgency))
            {
                ev.Allow = true;
            }
            //            if (csm == true)
            //{
            // Doors = Map.Doors;
            //System.Random random = new System.Random();
            //door3 = Doors[random.Next(Doors.Count)];
            //ev.Player.SetPosition(new Vector3(door3.localPos.x, door3.localPos.y + (float)1.5, door3.localPos.z));
            // ev.Player.ClearBroadcasts();
            //         ev.Player.Broadcast(5, "----[<color=#32CD32>SCP247</color>]----\n<color=#FF0000>你碰到了随机门以被传送</color>", false);

            //     }
            if (bscp79 == true)
            {
                if (ev.Player.GetTeam() == Team.SCP)
                {
                    if (new System.Random().Next(0, 100) >= 95)
                    {
                        ev.Allow = true;
                    }
                }
            }

            if ((scp005 == true) && (ev.Player.GetPlayerId() == scp005aid))
            {
                ev.Allow = true;

            }

            if (scp682.Contains(ev.Player.GetUserId()) && (ev.Player.GetRole() == RoleType.Scp93989))
            {
                if (new System.Random().Next(0, 100) >= 90)
                {
                    ev.Door.DestroyDoor(true);
                    ev.Allow = true;
                }

            }

            if (ev.Player.GetPlayerId() == scp181id)
            {
                System.Random random = new System.Random();
                if (random.Next(1, 0x1f) == 0x18)
                {
                    ev.Allow = true;
                }

            }

            if (ev.Player.GetPlayerId() == cxkid)
            {
                System.Random random = new System.Random();
                if (random.Next(1, 5) == 2)
                {
                    ev.Allow = false;
                    ev.Player.Broadcast(3, "你太菜了导致门没打开", false);
                }
                if (jntm == true)
                {
                    ev.Allow = true;
                    ev.Door.DestroyDoor(true);
                    ev.Player.ClearBroadcasts();
                    ev.Player.Broadcast(4, "你发动鸡你太美门都看不下去了", false);

                }

            }

            if ((ev.Player.GetRole() == RoleType.FacilityGuard) && (ev.Door.DoorName == "INTERCOM"))
            {
                ev.Door.DestroyDoor(true);
                Map.Broadcast("暴躁老哥" + ev.Player.GetNickname() + "一jio踹开了广播室", 5, false);

            }
            if ((ev.Player.GetTeam() == Team.MTF) && (ev.Door.DoorName == "INTERCOM"))
            {
                ev.Door.DestroyDoor(true);

                Map.Broadcast("暴躁老哥" + ev.Player.GetNickname() + "一jio踹开了广播室", 5, false);

            }
            if ((Dio2.Contains(ev.Player.GetUserId())) && (sjtz1 == true))
            {
                ev.Door.DestroyDoor(true);

                ev.Allow = true;

            }
            if ((Dio2.Contains(ev.Player.GetUserId()) == false) && (sjtz1 == true))
            {
                ev.Allow = false;

            }
            if (jljy2.Contains(ev.Player.GetUserId()))
            {
                int num3 = new System.Random().Next(1, 100);
                if (num3 >= 99)
                {
                    door2.Add(ev.Door);
                    ev.Player.Broadcast(5, "已经安放炸弹", false);
                }
            }
            if(中国制造 == true)
            {
                ev.Door.DestroyDoor(false);
            }
        }
        public void OnScp106Contain(Scp106ContainEvent ev)
        {
            Map.ClearBroadcasts();
            if(ev.Allow == true)
            {
                Map.Broadcast("<color=red>广播</color>:(因大腿骨粉碎机而痛苦大叫)\n为什么? 为什么!\n呜呜呜呜呜呜呜", 20, false);

            }
        }
        public void OnGeneratorUnlock(ref GeneratorUnlockEvent ev)
        {
            if(h == true)
            {
                ev.Allow = false;
                ev.Player.Broadcast(5, "当前79属于人类阵营", false);
            }
        }
        public void OnCheckRoundEnd(ref CheckRoundEndEvent ev)
        {
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            foreach (ReferenceHub player in Player.GetHubs())
            {
                if ((player.GetTeam() == Team.SCP) && (player.GetPlayerId() != scp650id))
                {
                    num++;
                }
                if (player.GetTeam() == Team.CHI)
                {
                    num2++;
                }
                if (player.GetRole() == RoleType.Scientist)
                {
                    num3++;
                }
                if ((player.GetRole() == RoleType.ClassD) && (player.GetPlayerId() != scp035id))
                {
                    num4++;
                }
                if (player.GetTeam() == Team.MTF)
                {
                    num5++;
                }
                if(h == true)
                {
                    if(player.GetRole()==RoleType.Scp079)
                    {
                        num--;

                    }
                }

            }

            
            if ((num4 == 0) && (num >= 1) && (num5 == 0) && (num3 == 0))
            {
                ev.ForceEnd = true;
            }
            if ((num == 0) && (num4 == 0) && (num5 >= 1))
            {
                ev.ForceEnd = true;
            }

        }
        public void OnDropItem(ref DropItemEvent ev)
        {
            Vector3 room = ev.Player.GetPosition();





            if ((ev.Item.id != ItemType.Ammo556) && (ev.Item.id != ItemType.Ammo762) && (ev.Item.id != ItemType.Ammo9mm) && (ev.Item.id != ItemType.Radio))
            {
                Vector3 randomSpawnPoint = Map.GetRandomSpawnPoint(RoleType.Scp173);
                float num = randomSpawnPoint.x + 20;
                float num2 = randomSpawnPoint.y + 20;
                float num3 = randomSpawnPoint.z + 20;
                float num4 = randomSpawnPoint.x - 20;
                float num5 = randomSpawnPoint.y - 20;
                float num6 = randomSpawnPoint.z - 20;
                if (ev.Player.GetPosition().x <= num && ev.Player.GetPosition().x >= num4 && ev.Player.GetPosition().y <= num2 && ev.Player.GetPosition().y >= num5 && ev.Player.GetPosition().z <= num3 && ev.Player.GetPosition().z >= num6)
                {
                    ev.Player.ClearBroadcasts();
                    ev.Player.Broadcast(5, "你尝试将物品放入 <color=yellow>SCP-1162</color> 获得另外一个物品", false);
                    int num7 = new System.Random().Next(1, 85);
                    if (num7 >= 1 && num7 <= 4)
                    {
                        ev.Allow = false;
                        ev.Player.RemoveItem(ev.Item);
                        ev.Player.AddItem(ItemType.SCP500);
                    }
                    if (num7 >= 5 && num7 <= 8)
                    {
                        ev.Allow = false;
                        ev.Player.RemoveItem(ev.Item);
                        ev.Player.AddItem(ItemType.Disarmer);
                    }
                    if (num7 >= 9 && num7 <= 12)
                    {
                        ev.Allow = false;
                        ev.Player.RemoveItem(ev.Item);
                        ev.Player.AddItem(ItemType.GrenadeFlash);
                    }
                    if (num7 >= 13 && num7 <= 16)
                    {
                        ev.Allow = false;
                        ev.Player.RemoveItem(ev.Item);
                        ev.Player.AddItem(ItemType.Flashlight);
                    }
                    if (num7 >= 17 && num7 <= 20)
                    {
                        ev.Allow = false;
                        ev.Player.RemoveItem(ev.Item);
                        ev.Player.AddItem(ItemType.Medkit);
                    }
                    if (num7 >= 21 && num7 <= 24)
                    {
                        ev.Allow = false;
                        ev.Player.RemoveItem(ev.Item);
                        ev.Player.AddItem(ItemType.Radio);
                    }
                    if (num7 >= 25 && num7 <= 27)
                    {
                        ev.Allow = false;
                        ev.Player.RemoveItem(ev.Item);
                        ev.Player.AddItem(ItemType.KeycardJanitor);
                    }
                    if (num7 >= 28 && num7 <= 30)
                    {
                        ev.Allow = false;
                        ev.Player.RemoveItem(ev.Item);
                        ev.Player.AddItem(ItemType.KeycardScientist);
                    }
                    if (num7 >= 31 && num7 <= 33)
                    {
                        ev.Allow = false;
                        ev.Player.RemoveItem(ev.Item);
                        ev.Player.AddItem(ItemType.KeycardSeniorGuard);
                    }
                    if (num7 >= 34 && num7 <= 36)
                    {
                        ev.Allow = false;
                        ev.Player.RemoveItem(ev.Item);
                        ev.Player.AddItem(ItemType.KeycardZoneManager);
                    }
                    if (num7 >= 37 && num7 <= 39)
                    {
                        ev.Allow = false;
                        ev.Player.RemoveItem(ev.Item);
                        ev.Player.AddItem(ItemType.KeycardScientistMajor);
                    }
                    if (num7 >= 40 && num7 <= 42)
                    {
                        ev.Allow = false;
                        ev.Player.RemoveItem(ev.Item);
                        ev.Player.AddItem(ItemType.KeycardGuard);
                    }
                    if (num7 >= 43 && num7 <= 44)
                    {
                        ev.Allow = false;
                        ev.Player.RemoveItem(ev.Item);
                        ev.Player.AddItem(ItemType.GunCOM15);
                    }
                    if (num7 >= 45 && num7 <= 46)
                    {
                        ev.Allow = false;
                        ev.Player.RemoveItem(ev.Item);
                        ev.Player.AddItem(ItemType.GunUSP);
                    }
                    if (num7 >= 47 && num7 <= 48)
                    {
                        ev.Allow = false;
                        ev.Player.RemoveItem(ev.Item);
                        ev.Player.AddItem(ItemType.KeycardNTFLieutenant);
                    }
                    if (num7 >= 49 && num7 <= 50)
                    {
                        ev.Allow = false;
                        ev.Player.RemoveItem(ev.Item);
                        ev.Player.AddItem(ItemType.GrenadeFlash);
                    }
                    if (num7 == 51)
                    {
                        ev.Allow = false;
                        ev.Player.RemoveItem(ev.Item);
                        ev.Player.AddItem(ItemType.MicroHID);
                    }
                    if (num7 == 52)
                    {
                        ev.Allow = false;
                        ev.Player.RemoveItem(ev.Item);
                        ev.Player.AddItem(ItemType.KeycardFacilityManager);
                    }
                    if (num7 >= 53 && num7 <= 56)
                    {
                        ev.Allow = false;
                        ev.Player.RemoveItem(ev.Item);
                        ev.Player.AddItem(ItemType.Ammo556);
                    }
                    bool flag23 = num7 >= 57 && num7 <= 60;
                    if (flag23)
                    {
                        ev.Allow = false;
                        ev.Player.RemoveItem(ev.Item);
                        ev.Player.AddItem(ItemType.Ammo762);
                    }
                    if (num7 >= 61 && num7 <= 64)
                    {
                        ev.Allow = false;
                        ev.Player.RemoveItem(ev.Item);
                        ev.Player.AddItem(ItemType.Ammo9mm);
                    }
                    if (num7 == 65)
                    {
                        ev.Allow = false;
                        ev.Player.RemoveItem(ev.Item);
                        ev.Player.AddItem(ItemType.KeycardContainmentEngineer);
                    }
                    if (num7 >= 66 && num7 <= 69)
                    {
                        ev.Allow = false;
                        ev.Player.RemoveItem(ev.Item);
                        ev.Player.AddItem(ItemType.WeaponManagerTablet);
                    }
                    if (num7 >= 70)
                    {
                        ev.Allow = false;
                        ev.Player.RemoveItem(ev.Item);
                        ev.Player.AddItem(ItemType.KeycardContainmentEngineer);
                    }
                }
            }








            if (ev.Player.GetPlayerId() == fkyyzid)
            {
                if(bindljf == true)
                {
                    if(ev.Item.id == ItemType.KeycardJanitor)
                    {
                        ev.Allow = false;
                        if (fkyyzcardint > 0)
                        {
                            Vector3 pos2 = ev.Player.GetPosition();
                            float numx1 = pos2.x + 30;
                            float num3 = pos2.y + 30;
                            float num4 = pos2.z + 30;
                            float num5 = pos2.x - 30;
                            float num6 = pos2.y - 30;
                            float num7 = pos2.z - 30;

                            foreach (ReferenceHub player3 in Player.GetHubs())
                            {
                                if ((player3.GetPosition().x <= numx1) && (player3.GetPosition().x >= num5) && (player3.GetPosition().y <= num3) && (player3.GetPosition().y >= num6) && ((player3.GetPosition().z <= num4) && (player3.GetPosition().z >= num7)))
                                {
                                    ljfwj.Add(player3);
                                    ljfuse = true;
                                    player3.Broadcast(5, "「灵击符」五秒内无法行动", false);
                                    Coroutines.Add(Timing.RunCoroutine(Ljfsx()));

                                }
                            }

                        }
                    }
                }
                if(bindjzsj == true)
                {
                    if(ev.Item.id == ItemType.KeycardScientist)
                    {
                        if (fkyyzcardint > 0)
                        {
                            ev.Allow = false;
                            fkyyzcardint--;
                            Coroutines.Add(Timing.RunCoroutine(Jzsjsx()));
                            jzsjuse = true;
                            Map.Broadcast("「静止时计」效果时间停止5s", 5, false);
                        }

                    }

                }
                if (bindtys == true)
                {
                    if (ev.Item.id == ItemType.KeycardScientistMajor)
                    {
                        if (fkyyzcardint > 0)
                        {
                            ev.Allow = false;
                            fkyyzcardint--;
                            Coroutines.Add(Timing.RunCoroutine(Tyssx()));

                            ev.Player.Broadcast(5, "你已获得5s钟反伤", false);
                            tysuse = true;
                        }

                    }
                }
            }
            if(jwhngwufashanghai == false)
            {
                if(bscd == false)
                {
                    if (ev.Player.GetPlayerId() == jwhngid)
                    {
                        if (ev.Item.id == ItemType.GrenadeFlash)
                        {
                            ev.Allow = false;
                            item = ev.Player.GetAllItems();
                            health = ev.Player.GetHealth();
                            if (ev.Player.GetRole() == RoleType.ChaosInsurgency)
                            {
                                ev.Player.SetRole(RoleType.NtfCadet, true);
                                foreach (Inventory.SyncItemInfo syncItemInfo in ev.Player.GetAllItems())
                                {
                                    ev.Player.RemoveItem(syncItemInfo);
                                }

                            }
                            if (ev.Player.GetRole() == RoleType.NtfCadet)
                            {
                                ev.Player.SetRole(RoleType.ChaosInsurgency, true);
                                foreach (Inventory.SyncItemInfo syncItemInfo in ev.Player.GetAllItems())
                                {
                                    ev.Player.RemoveItem(syncItemInfo);
                                }
                            }

                            Coroutines.Add(Timing.RunCoroutine(SecondCounter25()));
                        }
                    }
                }


            }
            if (ev.Player.GetPlayerId() == D9341id)
            {
                if (ev.Item.id == ItemType.GrenadeFlash)
                {
                    D9341.Broadcast(6, "存档成功", false);
                    ev.Allow = false;
                    ev.Player.RemoveItem(ev.Item);
                    D9341.AddItem(ItemType.GrenadeFlash);
                    D9341Item = D9341.GetAllItems();
                    D9341zb = D9341.GetPosition();

                    D9341js = D9341.GetRole();
                }
                if (ev.Item.id == ItemType.Flashlight)
                {
                    if (times <= 5)
                    {
                        D9341.SetRole(D9341js);
                        Coroutines.Add(Timing.RunCoroutine(SecondCounter28()));

                        times++;
                    }

                }
            }
            if (scp2006id == ev.Player.GetPlayerId())
            {
                if (ev.Item.id == ItemType.Coin)
                {
                    foreach (GameObject door in GameObject.FindGameObjectsWithTag("Door"))
                    {
                        doorlist.Add(door);
                    }

                    System.Random random = new System.Random();
                    GameObject doorchoice = doorlist[random.Next(doorlist.Count)];
                    ev.Player.SetPosition(new Vector3(doorchoice.transform.position.x, doorchoice.transform.position.y + (float)1.5, doorchoice.transform.position.z));
                    ev.Player.ClearBroadcasts();
                    ev.Player.Broadcast(5, "----[<color=#32CD32>SCP247</color>]----\n<color=#FF0000>你碰到了随机门以被传送</color>", false);
                    doorlist.Clear();
                }
            }
            if (ev.Player.GetPlayerId() == cxkid)
            {
                if (ev.Item.id == ItemType.Flashlight)
                {
                    jntm = true;
                    ev.Player.ClearBroadcasts();
                    ev.Allow = false;
                    ev.Player.RemoveItem(ev.Item);
                    ev.Player.AddItem(ItemType.Coin);
                    ev.Player.Broadcast(10, "成功发动鸡你太美时长10秒", false);

                }
            }
            if ((room.y <= -1f) && (room.y >= -7f))
            {
                if (coldwait233 == false)
                {
                    ev.Player.AddItem(ev.Item.id);
                    ev.Player.AddItem(ev.Item.id);
                    ev.Player.Broadcast(5, "复制成功", false);
                    coldwait233 = true;
                }
                if (coldwait233 == true)
                {
                    ev.Player.Broadcast(5, "038:累死我了一会再来呗QAQ", false);
                }
            }
            if (scp2818pick == true)
            {
                if ((ev.Item.id == ItemType.GunCOM15) && (scp2818.GetPlayerId() == ev.Player.GetPlayerId()))
                {
                    ev.Player.Broadcast(5, "SCP2818已经被扔下", false);
                    scp2818pick = false;
                    scp2818id = 0;
                    scp2818 = null;
                }
            }

            if ((Dio2.Contains(ev.Player.GetUserId())) && (ev.Item.id == ItemType.Flashlight) && (sjtz2 == false))
            {
                ev.Allow = false;
                ev.Player.RemoveItem(ev.Item);
                ev.Player.AddItem(ItemType.Coin);
                Map.ClearBroadcasts();
                Map.Broadcast("<color=#99FF00>「世界」时间停止了流动</color>", 1, false);
                Map.Broadcast("<color=#99FF00>1s过去了</color>", 1, false);
                Map.Broadcast("<color=#99FF00>2s过去了</color>", 1, false);
                Map.Broadcast("<color=#99FF00>3s过去了</color>", 1, false);
                Map.Broadcast("<color=#99FF00>4s过去了</color>", 1, false);
                Map.Broadcast("<color=#99FF00>5s过去了</color>", 1, false);
                Map.Broadcast("<color=#99FF00>6s过去了</color>", 1, false);
                Map.Broadcast("<color=#99FF00>7s过去了</color>", 1, false);
                Map.Broadcast("<color=#99FF00>8s过去了</color>", 1, false);
                Map.Broadcast("<color=#99FF00>9s过去了</color>", 1, false);
                sjtz1 = true;
                sjtz2 = true;
                cd = new Thread(CD);
                cd.Start();
            }
            if ((((((s173 == 0) || (s173 == 2)) && ((s096 == 0) || (s096 == 2))) && (((s939_53 == 0) || (s939_53 == 2)) && ((s939_89 == 0) || (s939_89 == 2)))) && ((s049 == 0) || (s049 == 2))) && ((s106 == 1) && (RoleSet != 1)))
            {
                Log.Info("当前场上只剩余一个SCP了");
                if (ev.Player.GetRole() == RoleType.NtfCommander)
                {
                    ev.Player.ClearBroadcasts();
                    ev.Player.Broadcast(5, "当前场上只剩下一个SCP了\n<color=#FF1493>你可以把你的指挥官卡丢出来</color>\n变为收容工程师卡", false);
                    if (ev.Item.id == ItemType.KeycardNTFCommander)
                    {
                        ev.Player.AddItem(ItemType.KeycardContainmentEngineer);
                        RoleSet = 1;
                    }
                }
            }
            else if ((((((s106 == 0) || (s106 == 2)) && ((s096 == 0) || (s096 == 2))) && (((s939_53 == 0) || (s939_53 == 2)) && ((s939_89 == 0) || (s939_89 == 2)))) && ((s049 == 0) || (s049 == 2))) && ((s173 == 1) && (RoleSet != 1)))
            {
                Log.Info("当前场上只剩余一个SCP了");
                if (ev.Player.GetRole() == RoleType.NtfCommander)
                {
                    ev.Player.ClearBroadcasts();
                    ev.Player.Broadcast(5, "当前场上只剩下一个SCP了\n<color=#FF1493>你可以把你的指挥官卡丢出来</color>\n变为收容工程师卡", false);
                    if (ev.Item.id == ItemType.KeycardNTFCommander)
                    {
                        ev.Player.AddItem(ItemType.KeycardContainmentEngineer);
                        RoleSet = 1;
                    }
                }
            }
            else if ((((((s106 == 0) || (s106 == 2)) && ((s173 == 0) || (s173 == 2))) && (((s939_53 == 0) || (s939_53 == 2)) && ((s939_89 == 0) || (s939_89 == 2)))) && ((s049 == 0) || (s049 == 2))) && ((s096 == 1) && (RoleSet != 1)))
            {
                Log.Info("当前场上只剩余一个SCP了");
                if (ev.Player.GetRole() == RoleType.NtfCommander)
                {
                    ev.Player.ClearBroadcasts();
                    ev.Player.Broadcast(5, "当前场上只剩下一个SCP了\n<color=#FF1493>你可以把你的指挥官卡丢出来</color>\n变为收容工程师卡", false);
                    if (ev.Item.id == ItemType.KeycardNTFCommander)
                    {
                        ev.Player.AddItem(ItemType.KeycardContainmentEngineer);
                        RoleSet = 1;
                    }
                }
            }
            else if ((((((s106 == 0) || (s106 == 2)) && ((s173 == 0) || (s173 == 2))) && (((s096 == 0) || (s096 == 2)) && ((s939_89 == 0) || (s939_89 == 2)))) && ((s049 == 0) || (s049 == 2))) && ((s939_53 == 1) && (RoleSet != 1)))
            {
                Log.Info("当前场上只剩余一个SCP了");
                if (ev.Player.GetRole() == RoleType.NtfCommander)
                {
                    ev.Player.ClearBroadcasts();
                    ev.Player.Broadcast(5, "当前场上只剩下一个SCP了\n<color=#FF1493>你可以把你的指挥官卡丢出来</color>\n变为收容工程师卡", false);
                    if (ev.Item.id == ItemType.KeycardNTFCommander)
                    {
                        ev.Player.AddItem(ItemType.KeycardContainmentEngineer);
                        RoleSet = 1;
                    }
                }
            }
            else if ((((((s106 == 0) || (s106 == 2)) && ((s173 == 0) || (s173 == 2))) && (((s096 == 0) || (s096 == 2)) && ((s939_53 == 0) || (s939_53 == 2)))) && ((s049 == 0) || (s049 == 2))) && ((s939_89 == 1) && (RoleSet != 1)))
            {
                Log.Info("当前场上只剩余一个SCP了");
                if (ev.Player.GetRole() == RoleType.NtfCommander)
                {
                    ev.Player.ClearBroadcasts();
                    ev.Player.Broadcast(5, "当前场上只剩下一个SCP了\n<color=#FF1493>你可以把你的指挥官卡丢出来</color>\n变为收容工程师卡", false);
                    if (ev.Item.id == ItemType.KeycardNTFCommander)
                    {
                        ev.Player.AddItem(ItemType.KeycardContainmentEngineer);
                        RoleSet = 1;
                    }
                }
            }
            else if ((((((s106 == 0) || (s106 == 2)) && ((s173 == 0) || (s173 == 2))) && (((s096 == 0) || (s096 == 2)) && ((s939_53 == 0) || (s939_53 == 2)))) && ((s939_89 == 0) || (s939_89 == 2))) && ((s049 == 1) && (RoleSet != 1)))
            {
                Log.Info("当前场上只剩余一个SCP了");
                if (ev.Player.GetRole() == RoleType.NtfCommander)
                {
                    ev.Player.ClearBroadcasts();
                    ev.Player.Broadcast(5, "当前场上只剩下一个SCP了\n<color=#FF1493>你可以把你的指挥官卡丢出来</color>\n变为收容工程师卡", false);
                    if (ev.Item.id == ItemType.KeycardNTFCommander)
                    {
                        ev.Player.AddItem(ItemType.KeycardContainmentEngineer);
                        RoleSet = 1;
                    }
                }
            }
        }
        public void CD()
        {
            Dio.AddHealth(120);
            Thread.Sleep(9000);
            pos1.Clear();
            sjtz1 = false;
            cd.Abort();
        }
        public void OnShoot(ref ShootEvent ev)
        {
            if (ev.Shooter.GetPlayerId() == scp3108playerid)
            {
                if (ev.Shooter.inventory.GetItemInHand().id == ItemType.GunCOM15)
                {
                    ev.Shooter.RemoveItem(ev.Shooter.inventory.GetItemInHand());
                    scp3108shotyes = true;
                }
            }
            if(ev.Shooter.GetPlayerId() == hdjjsid)
            {
                if(ev.Shooter.inventory.GetItemInHand().id == ItemType.GunE11SR)
                {
                    ev.Shooter.RemoveItem(ev.Shooter.inventory.GetItemInHand());
                    Coroutines.Add(Timing.RunCoroutine(HdjjsCD()));

                }
            }
            if (scp1577id.Contains(ev.Shooter.GetPlayerId()))
            {
                if (ev.Shooter.GetTeam() == Team.MTF)
                {
                    if (ev.Shooter.inventory.GetItemInHand().id == ItemType.GunCOM15)
                    {
                        scp1577pos = ev.Shooter.GetPosition();
                        Coroutines.Add(Timing.RunCoroutine(Scp1577bj()));
                        scp1577id = new List<int>();
                        Map.Broadcast("<color=lime>有人召唤了补给坐标" + scp1577pos.x + "|" + scp1577pos.y + "|" + scp1577pos.z + "按~输入.pos可获取你的坐标</color>", 5, false);
                        ev.Shooter.Broadcast(5, "<color=lime>去尽情白给吧qwq</color>", false);
                    }
                }
                else
                {
                    if (ev.Shooter.inventory.GetItemInHand().id == ItemType.GunCOM15)
                    {
                        scp1577pos = ev.Shooter.GetPosition();
                        Coroutines.Add(Timing.RunCoroutine(Scp1577bj()));
                        scp1577id = new List<int>();
                        Map.Broadcast("<color=lime>有人召唤了补给坐标" + scp1577pos.x + "|" + scp1577pos.y + "|" + scp1577pos.z + "按~输入.pos可获取你的坐标</color>", 5, false);
                        ev.Shooter.Broadcast(5, "<color=lime>你已经呼叫了补给</color>", false);
                    }
                }

            }
        }
        public void OnPickupItem(ref PickupItemEvent ev)
        {
            if(ev.Player.GetPlayerId() == hdjjsid)
            {
                if(ev.Item.ItemId == ItemType.GunE11SR)
                {
                    ev.Allow = false;
                }
            }
            if (ylb2.Contains(ev.Player.GetUserId()))
            {
                if (ev.Item.ItemId == ItemType.GrenadeFlash)
                {
                    ev.Allow = false;
                    ev.Item.Delete();

                    ev.Player.AddItem(ItemType.Medkit);

                }
                if (ev.Item.ItemId == ItemType.Radio)
                {
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.AddItem(ItemType.Medkit);
                }
                if (ev.Item.ItemId == ItemType.WeaponManagerTablet)
                {
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.AddItem(ItemType.Medkit);
                }
            }
            if (bpb2.Contains(ev.Player.GetPlayerId()))
            {
                if (ev.Item.ItemId == ItemType.GrenadeFlash)
                {
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.AddItem(ItemType.GrenadeFrag);

                }
                if (ev.Item.ItemId == ItemType.Radio)
                {
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.AddItem(ItemType.GrenadeFrag);
                }
                if (ev.Item.ItemId == ItemType.WeaponManagerTablet)
                {
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.AddItem(ItemType.GrenadeFrag);
                }
            }
            if ((a127d == true) && (ev.Item.ItemId == ItemType.GunUSP))
            {
                if (scp3108pick == false)
                {
                    scp3108playerid = ev.Player.GetPlayerId();
                    scp3108pick = true;
                    Map.Broadcast("<color=red>SCP-3108已被捡起被打中的人会强行转换身份</color>", 5, false);
                    ev.Player.Broadcast(5, "<color=lime>你捡起了</color>\n[<color=red>SCP-3108</color>]\n<color=lime>使用本手枪射中人会让他角色变化 你只能开一枪</color>", false);
                }
            }
            if (ev.Player.GetPlayerId() == scp914mid)
            {
                int cardup = new System.Random().Next(1, 4);
                if (cardup == 2)
                {
                    if (ev.Item.ItemId == ItemType.KeycardScientist)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardScientistMajor);
                    }
                    if (ev.Item.ItemId == ItemType.KeycardJanitor)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardScientist);
                    }
                    if (ev.Item.ItemId == ItemType.KeycardNTFLieutenant)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardNTFCommander);
                    }
                    if (ev.Item.ItemId == ItemType.KeycardScientistMajor)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardChaosInsurgency);
                    }
                    if (ev.Item.ItemId == ItemType.KeycardChaosInsurgency)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardNTFCommander);
                    }
                    if (ev.Item.ItemId == ItemType.KeycardNTFCommander)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardO5);
                    }
                    if (ev.Item.ItemId == ItemType.KeycardZoneManager)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardContainmentEngineer);
                    }

                    if (ev.Item.ItemId == ItemType.KeycardChaosInsurgency)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardO5);
                    }
                    if (ev.Item.ItemId == ItemType.GunCOM15)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunProject90);
                    }
                    if (ev.Item.ItemId == ItemType.GunCOM15)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunProject90);
                    }
                    if (ev.Item.ItemId == ItemType.GunProject90)
                    {
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunE11SR);
                    }
                    if (ev.Item.ItemId == ItemType.GunE11SR)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunLogicer);
                    }
                    if (ev.Item.ItemId == ItemType.GunLogicer)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.MicroHID);
                    }
                    if (ev.Item.ItemId == ItemType.GunCOM15)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunProject90);
                    }
                    if (ev.Item.ItemId == ItemType.Flashlight)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GrenadeFrag);
                    }

                }
                if (cardup == 3)
                {
                    if (ev.Item.ItemId == ItemType.KeycardScientistMajor)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardScientist);
                    }
                    if (ev.Item.ItemId == ItemType.KeycardScientist)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardJanitor);
                    }
                    if (ev.Item.ItemId == ItemType.KeycardNTFCommander)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardNTFCommander);
                    }
                    if (ev.Item.ItemId == ItemType.KeycardChaosInsurgency)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardScientistMajor);
                    }
                    if (ev.Item.ItemId == ItemType.KeycardChaosInsurgency)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardChaosInsurgency);
                    }
                    if (ev.Item.ItemId == ItemType.KeycardContainmentEngineer)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardZoneManager);

                    }
                    if (ev.Item.ItemId == ItemType.GunProject90)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunCOM15);

                    }
                    if (ev.Item.ItemId == ItemType.GunProject90)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunCOM15);
                    }
                    if (ev.Item.ItemId == ItemType.GunE11SR)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunProject90);
                    }
                    if (ev.Item.ItemId == ItemType.GunLogicer)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunE11SR);
                    }
                    if (ev.Item.ItemId == ItemType.MicroHID)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunLogicer);
                    }
                    if (ev.Item.ItemId == ItemType.GunProject90)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunCOM15);
                    }
                    if (ev.Item.ItemId == ItemType.GrenadeFrag)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.Flashlight);
                    }
                }
            }
            if (ev.Player.GetPlayerId() == scp181id)
            {
                if (ev.Item.ItemId == ItemType.KeycardScientist)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardScientistMajor);
                        ev.Player.Broadcast(5, "[<color=red>当当当当你的科学家变成了大科学家卡</color>]", false);
                    }

                }
                if (ev.Item.ItemId == ItemType.KeycardJanitor)
                {
                    int cardup = new System.Random().Next(1, 100);
                    Log.Info("测试" + cardup);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardScientist);
                        ev.Player.Broadcast(5, "[<color=red>当当当当你的清洁工变成了科学家卡</color>]", false);
                    }
                }
                if (ev.Item.ItemId == ItemType.KeycardNTFLieutenant)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Player.AddItem(ItemType.KeycardChaosInsurgency);
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.Broadcast(5, "[<color=red>当当当当你的士官卡变成了指挥官卡</color>]", false);
                    }
                }

                if (ev.Item.ItemId == ItemType.KeycardScientistMajor)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardChaosInsurgency);
                        ev.Player.Broadcast(5, "[<color=red>当当当当你的大科学家变成了收容工程师卡</color>]", false);
                    }

                }
                if (ev.Item.ItemId == ItemType.KeycardChaosInsurgency)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardNTFCommander);
                        ev.Player.Broadcast(5, "[<color=red>当当当当你的收容工程师卡变成了指挥官卡</color>]", false);
                    }
                }
                if (ev.Item.ItemId == ItemType.KeycardNTFCommander)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardO5);
                        ev.Player.Broadcast(5, "[<color=red>当当当当你的指挥官卡变成了黑卡</color>]", false);
                    }
                }
                if (ev.Item.ItemId == ItemType.KeycardZoneManager)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardChaosInsurgency);
                        ev.Player.Broadcast(5, "[<color=red>当当当当你的区域总监卡变成了设施总监卡</color>]", false);
                    }
                }
                if (ev.Item.ItemId == ItemType.KeycardJanitor)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardNTFLieutenant);
                        ev.Player.Broadcast(5, "[<color=red>当当当当你的九尾狐新兵卡变成了九尾狐士官卡</color>]", false);
                    }
                }
                if (ev.Item.ItemId == ItemType.KeycardJanitor)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardJanitor);
                        ev.Player.Broadcast(5, "[<color=red>当当当当你的保安卡变成了设施九尾狐新兵卡</color>]", false);
                    }
                }
                if (ev.Item.ItemId == ItemType.KeycardContainmentEngineer)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.KeycardO5);
                        ev.Player.Broadcast(5, "[<color=red>当当当当你的混沌卡变成了设施黑卡</color>]", false);
                    }
                }
                if (ev.Item.ItemId == ItemType.GunCOM15)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunProject90);
                        ev.Player.Broadcast(5, "[<color=red>当当当当你的小手枪变成了P90</color>]", false);
                    }
                }
                if (ev.Item.ItemId == ItemType.GunCOM15)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunProject90);
                        ev.Player.Broadcast(5, "[<color=red>当当当当你的小手枪变成了P90</color>]", false);
                    }
                }
                if (ev.Item.ItemId == ItemType.GunProject90)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunE11SR);
                        ev.Player.Broadcast(5, "[<color=red>当当当当你的P90变成了九尾步枪</color>]", false);
                    }
                }
                if (ev.Item.ItemId == ItemType.GunE11SR)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunLogicer);
                        ev.Player.Broadcast(5, "[<color=red>当当当当你的九尾步枪变成了大菠萝</color>]", false);
                    }
                }
                if (ev.Item.ItemId == ItemType.GunLogicer)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.MicroHID);
                        ev.Player.Broadcast(5, "[<color=red>当当当当你的大菠萝变成了电磁炮</color>]", false);
                    }
                }
                if (ev.Item.ItemId == ItemType.GunCOM15)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GunProject90);
                        ev.Player.Broadcast(5, "[<color=red>当当当当你的保安枪变成了P90</color>]", false);
                    }
                }
                if (ev.Item.ItemId == ItemType.Flashlight)
                {
                    int cardup = new System.Random().Next(1, 100);
                    if (cardup >= 80)
                    {
                        ev.Allow = false;
                        ev.Item.Delete();
                        ev.Player.AddItem(ItemType.GrenadeFrag);
                        ev.Player.Broadcast(5, "[<color=red>当当当当你的闪光弹枪变成了手榴弹</color>]", false);
                    }
                }
            }
            if ((scp1577pick == false) && (ev.Item.ItemId == ItemType.GunCOM15))
            {
                Vector3 scp1577pos2 = Map.GetRandomSpawnPoint(RoleType.Scp173);
                float num2 = scp1577pos2.x + 10;
                float num3 = scp1577pos2.y + 10;
                float num4 = scp1577pos2.z + 10;
                float num5 = scp1577pos2.x - 10;
                float num6 = scp1577pos2.y - 10;
                float num7 = scp1577pos2.z - 10;
                if ((ev.Player.GetPosition().x <= num2) && (ev.Player.GetPosition().x >= num5) && (ev.Player.GetPosition().y <= num3) && (ev.Player.GetPosition().y >= num6) && ((ev.Player.GetPosition().z <= num4) && (ev.Player.GetPosition().z >= num7)))
                {
                    scp1577pick = true;
                    scp1577id.Add(ev.Player.GetPlayerId());
                    ev.Player.Broadcast(5, "<color=lime>你捡起了 信号枪</color>\n[<color=red>SCP-1577</color>]\n<color=lime>使用本手枪射击可以呼叫空投</color>", false);
                }
            }
            else
            {
                if ((ev.Item.ItemId == ItemType.GunCOM15) && (scp2818pick == false))
                {
                    Map.Broadcast("SCP-2818已经被" + ev.Player.GetNickname() + "捡起", 5, false);
                    ev.Player.Broadcast(5, "你捡起了2818 开枪后瞬间死亡伤害1000点", false);
                    scp2818 = ev.Player;
                    scp2818id = ev.Player.GetPlayerId();
                    scp2818pick = true;
                }
            }
            if (ev.Item.ItemId == ItemType.KeycardJanitor)
            {
                if (scp005 == false)
                {
                    scp005aid = ev.Player.GetPlayerId();
                    ev.Player.Broadcast(5, "<color=lime>你捡起了</color>[<color=red>SCP-005</color>]", false);
                    scp005 = true;
                }
            }

            if (ev.Item.ItemId == ItemType.GunUSP)
            {
                a127 = false;
            }
            if (ev.Item.ItemId == ItemType.Coin)
            {
                int num = new System.Random().Next(1, 13);

                if (num == 1)
                {
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.AddItem(ItemType.Coin);
                    ev.Player.Broadcast(5, "<color=#FF1493>你的硬币变成了</color>\n[硬币]", false);
                    Log.Info("硬币变为了硬币| 玩家:" + ev.Player.GetNickname());
                }
                if (num == 2)
                {
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.AddItem(ItemType.MicroHID);
                    ev.Player.Broadcast(5, "<color=#FF1493>你的硬币变成了</color>\n[电磁炮·有电]", false);
                    Log.Info("硬币变为了电磁炮| 玩家:" + ev.Player.GetNickname());
                }
                if (num == 3)
                {
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.AddItem(ItemType.GunE11SR);
                    ev.Player.Broadcast(5, "<color=#FF1493>你的硬币变成了</color>\n[九尾步枪]", false);
                    Log.Info("硬币变为了九尾步枪| 玩家:" + ev.Player.GetNickname());
                }
                if (num == 4)
                {
                    ev.Player.AddItem(ItemType.KeycardChaosInsurgency);
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.Broadcast(5, "<color=#FF1493>你的硬币变成了</color>\n[收容工程师卡]", false);
                    Log.Info("硬币变为了收容工程师卡| 玩家:" + ev.Player.GetNickname());
                }
                if (num == 5)
                {
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.AddItem(ItemType.GrenadeFrag);
                    ev.Player.Broadcast(5, "<color=#FF1493>你的硬币变成了</color>\n[手雷]", false);
                    Log.Info("硬币变为了手雷| 玩家:" + ev.Player.GetNickname());
                }
                if (num == 6)
                {
                    ev.Player.AddItem(ItemType.Ammo556);
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.Broadcast(5, "<color=#FF1493>你的硬币变成了</color>\n[5.56子弹]", false);
                }
                if (num == 7)
                {
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.AddItem(ItemType.GunLogicer);
                    ev.Player.Broadcast(5, "<color=#FF1493>你的硬币变成了</color>\n[大菠萝]", false);
                }
                if (num == 8)
                {
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.AddItem(ItemType.KeycardGuard);
                    ev.Player.Broadcast(5, "<color=#FF1493>你的硬币变成了</color>\n[保安卡]", false);
                }
                if (num == 9)
                {
                    ev.Player.AddItem(ItemType.Radio);
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.Broadcast(5, "<color=#FF1493>你的硬币变成了</color>\n[对讲机有电]", false);
                }
                if (num == 10)
                {
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.AddItem(ItemType.KeycardScientist);
                    ev.Player.Broadcast(5, "<color=#FF1493>你的硬币变成了</color>\n[科学家卡]", false);
                }
                if (num == 11)
                {
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.AddItem(ItemType.SCP500);
                    ev.Player.Broadcast(5, "<color=#FF1493>你的硬币变成了</color>\n[科学家卡]", false);
                }
                if (num == 12)
                {
                    ev.Allow = false;
                    ev.Item.Delete();
                    ev.Player.AddItem(ItemType.Flashlight);
                    ev.Player.Broadcast(5, "<color=#FF1493>你的硬币变成了</color>\n[手电筒]", false);
                    Log.Info("硬币变为了手电筒| 玩家:" + ev.Player.GetNickname());
                }
            }

            if (ev.Player.GetPlayerId() == scp457id)
            {
                ev.Item.Delete();
            }
            if ((a127c == false) && (ev.Item.ItemId == ItemType.GunUSP))
            {
                a127c = true;

                a127 = true;
                ev.Player.Broadcast(5, "<color=lime>你捡起了</color>[<color=red>SCP-127</color>]\n<color=lime>当你扔掉或者死亡都SCP-127都会消失</color>", false);
                Map.Broadcast("SCP127力量已经出现", 10, false);
            }
            Vector3 pos2 = ev.Player.GetPosition();
            if ((pos2.y > -735) && (pos2.y < -730))
            {

                if (jkl == false)
                {
                    jkl = true;
                    jklid = ev.Player.GetUserId();
                    ev.Player.Broadcast(5, "你捡起了SCP-金坷垃使用后恢复500点血", false);
                    Map.Broadcast("SCP-金坷垃被捡起了", 5, false);

                }
            }


            if (Dio2.Contains(ev.Player.GetUserId()))
            {
                ev.Item.Delete();
            }

        }
        public void OnPlayerHurt(ref PlayerHurtEvent ev)
        {
            if(ev.Attacker.GetPlayerId() == hdjjsid)
            {
                if(ev.DamageType == DamageTypes.E11StandardRifle)
                {
                    ev.Amount = 60;
                }
            }
            if(ev.Player.GetPlayerId() == hdjjsid)
            {
                ev.Amount += ev.Amount;
            }
            if(ev.Player.GetPlayerId() == tlid)
            {
                if(ev.Attacker.GetTeam() == Team.SCP && (ev.DamageType != DamageTypes.Usp) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null))
                {
                    ev.Amount = 20;
                }
                else if((ev.DamageType != DamageTypes.Usp) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null))
                {
                    ev.Amount = 10;
                }
            }
            if((ev.Player.GetPlayerId() == scp49jid)&&(xp < 600))
            {
                if(ev.Attacker.GetRole() == RoleType.Scp049)
                {
                    ev.Amount = 0;
                }
            }
            if(lxyes == true)
            {
                if(ev.Attacker.GetPlayerId() == fkyyzid)
                {
                    ev.Amount += 10;
                }
            }
            if((ev.Player.GetPlayerId() == Gears博士id)&&(ev.Attacker !=ev.Player))
            {
                if(ev.DamageType == DamageTypes.Falldown)
                {
                    ev.Amount = 0;
                }
                if(ev.DamageType == DamageTypes.Scp173)
                {
                    ev.Amount = 50;
                }
            }
            if(Dio2.Contains(ev.Player.GetUserId()) && (ev.DamageType != DamageTypes.Usp) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null))
            {
                Dio.AddHealth(1);
            }
            if (ev.DamageType == DamageTypes.Tesla)
            {
                if (ev.Attacker.GetPlayerId() == ev.Player.GetPlayerId())
                {
                    if (ev.Player.GetTeam() == Team.SCP)
                    {
                        if (scp79==true)
                        {
                            ev.Amount = 0;
                        }
                    }
                    else
                    {
                        if (h == true)
                        {
                            ev.Amount = 0;
                        }
                    }
                }

            }
            if (fkyyzyes == true)
            {
                if (zybuse == true)
                {
                    if ((ev.Player.GetPlayerId() == fkyyzid)&& (ev.DamageType != DamageTypes.Usp) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null))
                    {
                        ev.Amount += 10;
                    }
                    if ((ev.Attacker.GetPlayerId() == fkyyzid) && (ev.DamageType != DamageTypes.Usp) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null))
                    {
                        ev.Amount += 20;
                    }
                }
                if (tysuse == true)
                {
                    if (ev.Player.GetPlayerId() == fkyyzid)
                    {
                        ev.Amount = 10;
                        ev.Attacker.AddHealth(-20);
                    }
                }
                if (ljfuse == true)
                {
                    if (ljfwj.Contains(ev.Attacker) && (ev.DamageType != DamageTypes.Usp) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null))
                    {
                        ev.Amount = 0;
                    }
                    if ((ev.Attacker.GetPlayerId() == fkyyzid) && (ev.DamageType != DamageTypes.Usp) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null))
                    {
                        ev.Amount = 0;
                    }
                }
                if ((jzsjuse == true) && (ev.DamageType != DamageTypes.Usp) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null))
                {
                    ev.Amount = 0;
                }
            }

            if (scp_999.Contains(ev.Player.GetUserId()) && (ev.Attacker.GetTeam() == Team.SCP))
            {
                ev.Amount = 50;
            }
            LCZ = ev.Player.GetPosition();
            int num = 0;
            int num2 = 0;
            if (ev.Attacker.GetPlayerId() == scp650id)
            {
                gjtr++;
                ev.Attacker.Broadcast(4, "<color=red>停止多次攻击刷血否则您将会被请出服务器</color>", false);
                if (gjtr == 50)
                {
                    ev.Attacker.BanPlayer(0, "你触发650刷血限制");

                }
            }
            if (ev.Attacker.GetPlayerId() == scp3108playerid)
            {
                if ((ev.DamageType == DamageTypes.Usp) && (ev.Player.GetPlayerId() != scp650id) && (ev.Player.GetPlayerId() != scp457id))
                {
                    scp3108playerid = 0;
                    scp3108shotatplayerpos = ev.Player.GetPosition();
                    int Rolenum = new System.Random().Next(1, 17);
                    if (Rolenum == 1)
                    {
                        ev.Player.SetRole(RoleType.Scientist);
                    }
                    if (Rolenum == 2)
                    {
                        ev.Player.SetRole(RoleType.ChaosInsurgency);
                    }
                    if (Rolenum == 3)
                    {
                        ev.Player.SetRole(RoleType.FacilityGuard);
                    }
                    if (Rolenum == 4)
                    {
                        ev.Player.SetRole(RoleType.NtfCadet);
                    }
                    if (Rolenum == 5)
                    {
                        ev.Player.SetRole(RoleType.NtfCommander);
                    }
                    if (Rolenum == 6)
                    {
                        ev.Player.SetRole(RoleType.NtfLieutenant);
                    }
                    if (Rolenum == 7)
                    {
                        ev.Player.SetRole(RoleType.NtfScientist);
                    }
                    if (Rolenum == 8)
                    {
                        ev.Player.SetRole(RoleType.Scp0492);
                    }
                    if (Rolenum == 9)
                    {
                        ev.Player.SetRole(RoleType.Scp079);
                    }
                    if (Rolenum == 10)
                    {
                        ev.Player.SetRole(RoleType.Scp106);
                    }
                    if (Rolenum == 11)
                    {
                        ev.Player.SetRole(RoleType.Scp173);
                    }
                    if (Rolenum == 12)
                    {
                        ev.Player.SetRole(RoleType.Scp93953);
                    }
                    if (Rolenum == 13)
                    {
                        ev.Player.SetRole(RoleType.Scp93989);
                    }
                    if (Rolenum == 14)
                    {
                        ev.Player.SetRole(RoleType.Tutorial);
                    }
                    ev.Player.Broadcast(5, "<color=red>你被SCP-3108射击已经转变身份</color>", false);

                    ev.Player.SetPosition(scp3108shotatplayerpos);
                }
            }
            if ((ev.Attacker.GetPlayerId() == scp650id) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure))
            {
                ev.Amount = 0;

            }
            if ((ev.Attacker.GetRole() == RoleType.Scp173) && (Dio2.Contains(ev.Player.GetUserId())) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure))
            {
                ev.Amount = 100;
            }
            if ((ev.Attacker.GetTeam() == Team.SCP) && (ev.Player.GetPlayerId() == scp457id))
            {
                ev.Amount = 0;
            }
            if ((ev.Attacker.GetPlayerId() == scp457id) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker.GetRole() == RoleType.Tutorial) && (ev.Player.GetPlayerId() != scp457id))
            {
                ev.Amount = 0;
            }
            if ((ev.Attacker.GetPlayerId() == scp939id) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker.GetRole() == RoleType.Scp93953) && (ev.Player.GetPlayerId() != scp035id) && (LLBS233.Contains(ev.Player.GetPlayerId()) == false))
            {
                ev.Amount = 100f;
            }
            if (ev.Player.GetPlayerId() == cxkid)
            {
                if (jntm == true)
                {
                    int num3 = new System.Random().Next(1, 100);
                    if (num3 >= 50)
                    {
                        ev.Amount = 0;
                    }
                }
            }
            if (ev.Player.GetPlayerId() == scp073id)
            {
                if ((ev.Player.GetPlayerId() != scp650id) && (ev.Attacker.GetTeam() == Team.SCP) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure))
                {
                    ev.Amount = 10;
                    ev.Attacker.AddHealth(-30);
                }
            }
            if (ev.Player.GetPlayerId() == scp073id)
            {
                if ((ev.Attacker.GetTeam() != Team.MTF) && (ev.Attacker.GetRole() != RoleType.Scientist) && (ev.Attacker.GetTeam() != Team.SCP) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure))
                {

                    ev.Amount = 3;
                    ev.Attacker.AddHealth(-5);

                }
            }
            if ((scp682.Contains(ev.Attacker.GetUserId())) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Usp) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker.GetRole() == RoleType.Scp93989) && (ev.Player.GetPlayerId() != scp035id) && (LLBS233.Contains(ev.Player.GetPlayerId()) == false))
            {
                ev.Amount = 300f;
                ev.Attacker.AddHealth(100);
            }
            if ((ev.Attacker.GetPlayerId() == scpqblid2) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure))
            {
                ev.Amount = 0;
            }
            if ((ev.Player.GetUserId() == scpqblid) && (ev.Amount >= scpqbl.GetHealth()))
            {
                ev.Amount = 0;
                scpqbl.SetRole(RoleType.Scp93989);
                scpqblid2 = scpqbl.GetPlayerId();
                scpqbl3 = ev.Player;
                scpqbl = null;
                scpqblid = null;
                Setrank_new("SCP-乔碧萝", "yellow", ev.Player);
                Map.Broadcast("我是颜值主播qwq", 7, false);
            }
            if ((ev.Player.GetPlayerId() == scp181id) && (ev.Attacker.GetTeam() == Team.SCP))
            {
                System.Random random = new System.Random();
                if (random.Next(1, 3) == 2)
                {
                    ev.Attacker.AddHealth(-10);
                    ev.Amount = 0;
                }
            }
            if (scp2006a.Contains(ev.Player.GetUserId()) && (ev.Attacker.GetPlayerId() != scp650id))
            {
                if (ev.Attacker.GetTeam() > Team.SCP)
                {
                    ev.Amount = 10;
                }
            }
            if ((ev.Player.GetPlayerId() == D9341id))
            {
                if ((ev.Amount >= ev.Player.GetHealth()) && (times <= 5))
                {
                    ev.Amount = 0;
                    
                    D9341.SetRole(D9341js);
                    Coroutines.Add(Timing.RunCoroutine(SecondCounter28()));
                    times++;
                }

            }

            if ((scp2818pick == true))
            {
                if ((scp2818id == ev.Attacker.GetPlayerId()) && (ev.DamageType == DamageTypes.Com15))
                {
                    if (ev.Player.GetRole() == RoleType.Scp106)
                    {
                        ev.Amount = 300;
                        scp2818.Kill();
                        scp2818.SetRole(RoleType.Spectator);
                        scp2818pick = false;
                        scp2818id = 0;
                        scp2818 = null;
                    }
                    else
                    {
                        ev.Amount = 1000;
                        scp2818.Kill();
                        scp2818.SetRole(RoleType.Spectator);
                        scp2818pick = false;
                        scp2818 = null;
                        scp2818id = 0;
                    }
                }
            }
            if (ev.Attacker.GetRole() == RoleType.Scp049)
            {
                if ((lv == 3) && (ev.Player.GetPlayerId() != scp076id)&&(ev.Attacker.GetPlayerId() != scp49jid) && (LLBS233.Contains(ev.Player.GetPlayerId()) == false) && (ev.Player.GetPlayerId() != scp457id) &&(scp_999.Contains(ev.Player.GetUserId()) == false)&&(Dio2.Contains(ev.Player.GetUserId())==false))

                {
                    int num33 = new System.Random().Next(1, 3);
                    if(num33 == 2)
                    {
                        ev.Amount = 0;
                        ev.Player.SetRole(RoleType.Scp0492, true);
                    }

                }
            }
            if ((ev.Player.GetPlayerId() != scp650id) && (ev.Player.GetPlayerId() == scp076id))
            {
                if ((ev.Attacker.GetRole() == RoleType.Scp173) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure))
                {
                    ev.Amount = 20;
                }
                if ((ev.Attacker.GetRole() == RoleType.Scp049) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure))
                {
                    ev.Amount = 20;
                }
                if ((ev.Attacker.GetRole() == RoleType.Scp0492) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure))
                {
                    ev.Amount = 10;
                }
                if ((ev.Attacker.GetRole() == RoleType.Scp096) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure))
                {
                    ev.Amount = 20;
                }
                if ((ev.Attacker.GetRole() == RoleType.Scp93953) || (ev.Attacker.GetRole() == RoleType.Scp93989))
                {
                    ev.Amount = 15;
                }
                if ((ev.Attacker.GetTeam() != Team.SCP) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure))
                {
                    ev.Amount = 7;
                }
            }
            if (yshkq == false)
            {
                if (roundstart == true)
                {
                    if ((ev.Attacker.GetRole() == RoleType.Scientist) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null))
                    {
                        if (ev.Player.GetRole() == RoleType.Scientist)
                        {
                            ev.Amount = 0;
                        }
                        if (ev.Player.GetTeam() == Team.MTF)
                        {
                            ev.Amount = 0;
                        }
                    }
                    else if (ev.DamageType == DamageTypes.Tesla)
                    {
                        if (ev.Attacker.GetPlayerId() != ev.Player.GetPlayerId())
                        {
                            if (ev.Player.GetRole() == RoleType.Scientist)
                            {
                                ev.Amount = 0;
                            }
                            if (ev.Player.GetTeam() == Team.MTF)
                            {
                                ev.Amount = 0;
                            }
                        }
                    }
                    if ((ev.Attacker.GetTeam() == Team.CHI) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null) && (ev.Player.GetPlayerId() != scp035id))
                    {
                        if (ev.Player.GetRole() == RoleType.ClassD)
                        {
                            ev.Amount = 0;
                        }
                        if (ev.Player.GetTeam() == Team.CHI)
                        {
                            ev.Amount = 0;
                        }
                    }
                    else if (ev.DamageType == DamageTypes.Tesla)
                    {
                        if (ev.Attacker.GetPlayerId() != ev.Player.GetPlayerId())
                        {
                            if (ev.Player.GetRole() == RoleType.Scientist)
                            {
                                ev.Amount = 0;
                            }
                            if (ev.Player.GetTeam() == Team.MTF)
                            {
                                ev.Amount = 0;
                            }
                        }
                    }
                    if ((ev.Attacker.GetRole() == RoleType.ClassD) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null) && (ev.Player.GetPlayerId() != scp035id))
                    {
                        if (ev.Player.GetRole() == RoleType.ClassD)
                        {
                            ev.Amount = 0;
                        }
                        if (ev.Player.GetTeam() == Team.CHI)
                        {
                            ev.Amount = 0;
                        }
                    }
                    else if (ev.DamageType == DamageTypes.Tesla)
                    {
                        if (ev.Attacker.GetPlayerId() != ev.Player.GetPlayerId())
                        {
                            if (ev.Player.GetRole() == RoleType.Scientist)
                            {
                                ev.Amount = 0;
                            }
                            if (ev.Player.GetRole() == RoleType.Scientist)
                            {
                                ev.Amount = 0;
                            }
                        }
                    }
                    if ((ev.Attacker.GetTeam() == Team.MTF) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null))
                    {
                        if (ev.Player.GetRole() == RoleType.Scientist)
                        {
                            ev.Amount = 0;
                        }
                        if (ev.Player.GetTeam() == Team.MTF)
                        {
                            ev.Amount = 0;
                        }
                    }
                    else if (ev.DamageType == DamageTypes.Tesla)
                    {
                        if (ev.Attacker.GetPlayerId() != ev.Player.GetPlayerId())
                        {
                            if (ev.Player.GetRole() == RoleType.Scientist)
                            {
                                ev.Amount = 0;
                            }
                            if (ev.Player.GetTeam() == Team.MTF)
                            {
                                ev.Amount = 0;
                            }
                        }
                    }

                }
            }
            if (ev.Player.GetPlayerId() == scp49jid)
            {
                if (ev.Amount >= ev.Player.GetHealth() && (ev.Player.GetRole() != RoleType.Scp0492))
                {
                    ev.Amount = 0;
                    ev.Player.SetRole(RoleType.Scp0492, true);
                    Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(scp49j, 1000)));
                    Setrank_new("SCP-49-J", "yellow", ev.Player);
                    ev.Player.Broadcast(10, "<color=#FFC0CB>[SCP-49-J 瘟疫二逼]</color>\n<color=#00FFFF>你无法攻击人 但是你可以拉起小僵尸</color>\n<color=#FFC0CB>当经验超过600后你可以攻击人类</color>", false);
                }
            }
            if (jwhngyes == true)
            {
                if (jwhngwufashanghai == false)
                {
                    if (ev.Attacker.GetTeam() == Team.MTF)
                    {
                        if (ev.Player.GetPlayerId() == jwhhkid)
                        {
                            ev.Amount = 20;
                        }
                    }
                    if (ev.Attacker.GetPlayerId() == jwhngid)
                    {
                        if (ev.Attacker.GetTeam() == Team.MTF)
                        {
                            if (ev.Player.GetTeam() == Team.MTF)
                            {
                                ev.Player.Broadcast(1, "无法攻击你现在是伪装模式", false);
                                ev.Amount = 0;
                            }
                        }
                    }
                    if (ev.Attacker.GetRole() == RoleType.ChaosInsurgency)
                    {
                        if (ev.Player.GetPlayerId() == jwhngid)
                        {
                            ev.Amount = 0;
                            ev.Player.ClearBroadcasts();
                            ev.Player.Broadcast(1, "停火是友军", false);
                        }
                    }

                }
            }
            if ((Dio2.Contains(ev.Player.GetUserId())) && (sjtz1 == true) && (ev.DamageType != DamageTypes.Nuke))
            {
                ev.Amount = 0;
            }
            if (ev.Attacker.GetPlayerId() == scp076id)
            {
                if (ev.Player.GetTeam() == Team.SCP)
                {
                    ev.Amount += 10;
                }
            }
            foreach (ReferenceHub player in Player.GetHubs())
            {
                if (player.GetRole() == RoleType.ChaosInsurgency)
                {
                    num++;
                }
                if (player.GetTeam() == Team.MTF)
                {
                    num2++;
                }
            }
            if ((ev.Attacker.GetPlayerId() == scp035id) && (ev.Player.GetTeam() > Team.SCP) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null))
            {
                ev.Amount = 20;
            }
            if ((ev.Player.GetPlayerId() == scp035id) && (ev.Attacker.GetTeam() == Team.SCP) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null))
            {
                ev.Amount = 50;
            }
            if ((ev.Player.GetPlayerId() == scp035id) && (ev.Attacker.GetTeam() > Team.SCP) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null))
            {
                ev.Amount = 50;
            }
            foreach (int num4 in touxiang)
            {
                if ((num4 == ev.Player.GetPlayerId()) && ((ev.Attacker.GetTeam() == Team.MTF) || (ev.Attacker.GetRole() == RoleType.Scientist)) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null) && (ev.Player.GetPlayerId() != ev.Attacker.GetPlayerId()) && (num == 0))
                {
                    ev.Attacker.Broadcast(2, "该玩家处于投降状态，你只能对他造成1伤害\n<color=#00FF7F>你自身也受到了3伤害</color>", false);
                    ev.Amount = 1f;
                    Log.Info(string.Concat(new object[] { "玩家: ", ev.Attacker.GetNickname(), " 正在攻击: ", ev.Player.GetNickname(), " 当前场上混沌: ", num2 }));
                }
                if ((num4 == ev.Player.GetPlayerId()) && ((ev.Attacker.GetTeam() == Team.MTF) || (ev.Attacker.GetRole() == RoleType.Scientist)) && (num > 0))
                {
                    Log.Info("混沌人数:" + num);
                    Log.Info("MTF人数:" + num2);
                    ev.Player.Broadcast(2, "由于场上存在混沌\n<color=#00FF7F>你的保护已失效</color>", false);
                    Log.Info(string.Concat(new object[] { "玩家: ", ev.Player.GetNickname(), "受到攻击,但无保护 | 当前场上混沌个数:", num }));
                }
                if ((num4 == ev.Player.GetPlayerId()) && (ev.Attacker.GetRole() == RoleType.ChaosInsurgency) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall)&& (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null) && (ev.Player.GetPlayerId() != ev.Attacker.GetPlayerId()) && (num2 == 0) && (ev.Player.GetRole() == RoleType.Scientist))
                {
                    Log.Info("混沌人数:" + num);
                    Log.Info("MTF人数:" + num2);
                    ev.Attacker.Broadcast(2, "该玩家处于投降状态，你只能对他造成1伤害\n<color=#00FF7F>你自身也受到了3伤害</color>", false);

                    Log.Info(string.Concat(new object[] { "玩家: ", ev.Attacker.GetNickname(), " 正在攻击: ", ev.Player.GetNickname(), " 当前场上MTF: ", num2 }));
                }
                if ((num4 == ev.Player.GetPlayerId()) && (ev.Attacker.GetRole() == RoleType.ChaosInsurgency) && (num2 > 0))
                {
                    Log.Info("混沌人数:" + num);
                    Log.Info("MTF人数:" + num2);
                    ev.Player.Broadcast(2, "由于场上存在MTF阵营\n<color=#00FF7F>你的保护已失效</color>", false);
                    Log.Info(string.Concat(new object[] { "玩家: ", ev.Player.GetNickname(), "受到攻击,但无保护 | 当前场上九尾个数:", num2 }));
                }
                if ((num4 == ev.Attacker.GetPlayerId()) && ((ev.Player.GetTeam() == Team.MTF) || (ev.Player.GetRole() == RoleType.Scientist)) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Player != null) && (ev.Player.GetPlayerId() != ev.Attacker.GetPlayerId()) && (num == 0))
                {
                    ev.Attacker.Broadcast(2, "你处于投降状态，你无法伤害MTF阵营", false);
                    ev.Amount = 0f;
                }
                if ((num4 == ev.Attacker.GetPlayerId()) && (ev.Player.GetTeam() == Team.CHI) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Player != null) && (ev.Player.GetPlayerId() != ev.Attacker.GetPlayerId()) && (num2 == 0))
                {
                    ev.Attacker.Broadcast(2, "你处于投降状态，你无法伤害混沌阵营", false);
                    ev.Amount = 0f;
                }
            }
            if (((ev.Player.GetRole() == RoleType.ClassD) || (ev.Player.GetRole() == RoleType.Scientist)) && (ev.DamageType == DamageTypes.Scp049))
            {
                for (int i = 0; i <= 100; i++)
                {
                    if (touxiang[i] == ev.Player.GetPlayerId())
                    {
                        touxiang[i] = 0;
                    }
                }
            }
            if (ev.Player.GetRole() == RoleType.Scp173)
            {
                if ((ev.DamageType == DamageTypes.Logicer) || (ev.DamageType == DamageTypes.E11StandardRifle)|| (ev.DamageType == DamageTypes.P90) || (ev.DamageType == DamageTypes.Mp7))
                {
                    ev.Amount = 3f;
                }
                if (ev.DamageType == DamageTypes.Usp)
                {
                    ev.Amount += 50f;
                }
            }
            if ((ev.Player.GetRole() == RoleType.Scp106) && (((((ev.DamageType == DamageTypes.Usp) || (ev.DamageType == DamageTypes.Logicer)) || ((ev.DamageType == DamageTypes.E11StandardRifle) || (ev.DamageType == DamageTypes.P90))) || (ev.DamageType == DamageTypes.Mp7)) || (ev.DamageType == DamageTypes.Com15) && (scp2818.GetPlayerId() != ev.Attacker.GetPlayerId())))
            {
                ev.Amount = 1f;
            }

            if ((LLBS233.Contains(ev.Player.GetPlayerId())) && (ev.Attacker.GetTeam() == Team.SCP) && (ev.Player.GetPlayerId() != scp650id))
            {
                ev.Amount = 20f;
            }
            if ((a127 == true) && (ev.DamageType == DamageTypes.Usp))
            {
                ev.Amount = 100;
                a127b++;
                if (a127b == 10)
                {
                    a127 = false;
                    a127c = true;
                    a127d = true;
                    Map.Broadcast("SCP127力量已经消失", 10, false);
                }

            }
            if ((ev.Attacker.GetPlayerId() == scp650id) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure))
            {
                ev.Amount = 0;
            }

            if (scp_999.Contains(ev.Attacker.GetUserId()) && (ev.DamageType != DamageTypes.Usp) && (ev.DamageType != DamageTypes.Tesla) && (ev.DamageType != DamageTypes.Decont) && (ev.DamageType != DamageTypes.Falldown) && (ev.DamageType != DamageTypes.Flying) && (ev.DamageType != DamageTypes.Nuke) && (ev.DamageType != DamageTypes.Pocket) && (ev.DamageType != DamageTypes.Wall) && (ev.DamageType != DamageTypes.Lure) && (ev.Attacker != null))
            {
                ev.Amount = 0;
                if (ev.Player.GetHealth() <= 8000)
                {
                    ev.Player.AddHealth(2);
                    if ((ev.Player.GetTeam() == Team.SCP) && (ev.Player.GetRole() != RoleType.Scp096))
                    {
                        ev.Player.AddHealth(3);
                    }
                    if ((ev.Player.GetPlayerId() == scp073id) || (ev.Player == mrfish) || (ev.Player.GetPlayerId() == scp076id))
                    {
                        if (ev.Player.GetHealth() >= 600)
                        {
                            ev.Player.SetHealth(600);
                        }
                    }
                }

            }
            else if (ev.DamageType == DamageTypes.Tesla)
            {
                if ((scp_999.Contains(ev.Attacker.GetUserId())) && (ev.Attacker.GetPlayerId() != ev.Player.GetPlayerId()))
                {
                    ev.Amount = 0;
                    ev.Player.AddHealth(10);
                }
            }
            if(ev.Player.GetPlayerId() == fkyyzid &&(ev.DamageType == DamageTypes.Scp207))
            {
                ev.Amount = 0;
            }
        }
        public void OnPocketDimEscaped(PocketDimEscapedEvent ev)
        {
            int num = new System.Random().Next(1, 4);
            if (num == 1)
            {
                ev.Player.AddItem(ItemType.Radio);
                ev.Player.Broadcast(10, "<color=#FF1493>你在口袋里搜刮到了</color>\n对讲机", false);
            }
            else if (num == 2)
            {
                ev.Player.AddItem(ItemType.Medkit);
                ev.Player.Broadcast(10, "<color=#FF1493>你在口袋里搜刮到了</color>\n医疗包", false);
            }
            else if (num == 3)
            {
                ev.Player.AddItem(ItemType.Flashlight);
                ev.Player.Broadcast(10, "<color=#FF1493>你在口袋里搜刮到了</color>\n闪光弹", false);
            }
        }
        public void OnScp079LvlGain(Scp079LvlGainEvent ev)
        {
            if (h == true)
            {
                ev.Player.scp079PlayerScript.NetworkmaxMana = 130;
                ev.Player.Broadcast(10, "<color=#FFC0CB>[消息]</color>\n你升级了,但是你的\n" + "你的电量被限制到了130点QAQ", false);
            }
        }
        public void OnSetClass(SetClassEvent ev)
        {
            if (ev.Player.GetRole() == RoleType.Scp079)
            {
                if(ev.Player.GetRole() == RoleType.ClassD)
                {
                    Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 100)));

                }
                if (ev.Player.GetRole() == RoleType.Scientist)
                {
                    Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 120)));
                }
                if (ev.Player.GetRole() == RoleType.NtfCadet)
                {
                    Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 100)));
                }
                if (ev.Player.GetRole() == RoleType.NtfCommander)
                {
                    Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 150)));
                }
                if (ev.Player.GetRole() == RoleType.NtfLieutenant)
                {
                    Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 120)));
                }
                if (ev.Player.GetRole() == RoleType.ChaosInsurgency)
                {
                    Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 120)));
                }
                this.scp079id = ev.Player.GetPlayerId();
                if (choise == false)
                {
                    ev.Player.SendMessage("==========SCP079============");
                    ev.Player.SendMessage(".scp         选择本局帮助SCP");
                    ev.Player.SendMessage(".h           选择本局帮助人类");
                    Setrank_new("SCP079 - 最大电力:130 | 电力恢复:3AP/s   未选择帮助倾向", "aqua", ev.Player);
                    ev.Player.Broadcast(15, "<color=#FFC0CB>---[SCP079]---</color>\n<color=#00FFFF>HP:无限  </color><color=aqua>你可以耗费电量开门和锁门 \n 清点键盘数字键1左边的~键选择本局所属阵营，如果看不到提示则向上翻</color>", false);
                }
                if (choise == true)
                {
                    if (scp79 == true)
                    {
                        Setrank_new("SCP079 -  帮助SCP", "aqua", ev.Player);
                        ev.Player.Broadcast(15, "<color=#FFC0CB>---[SCP079]---</color>\n<color=#00FFFF>HP:无限  </color><color=aqua>你可以耗费电量开门和锁门 \n 本局079选择帮助SCP</color>", false);
                    }
                    if (h == true)
                    {
                        Setrank_new("SCP079 - 最大电力:130 | 电力恢复:3AP/s   帮助人类", "aqua", ev.Player);
                        ev.Player.Broadcast(15, "<color=#FFC0CB>---[SCP079]---</color>\n<color=#00FFFF>HP:无限  </color><color=aqua>你可以耗费电量开门和锁门 \n 本局079选择帮助人类</color>", false);
                    }

                }
            }
            if (ev.Player.GetRole() == RoleType.Scp173)
            {
                ev.Player.Broadcast(10, "<color=#FFC0CB>---[SCP173]---</color>\n<color=#00FFFF>HP:4200  </color>你拥有一种特殊能力\n受到除手炮以外的<color=#FFD700>枪械伤害只有3点</color>", false);
                SCP173 = "SCP173";
                Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 4200)));
                s173 = 1;
            }
            if (ev.Player.GetRole() == RoleType.Scp049)
            {
                Setrank_new("当前等级:" + lv + "经验值:" + xp, "pink", ev.Player);
                SCP049 = "SCP049";
                s173 = 1;
                Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player,3000)));

                ev.Player.Broadcast(10, "<color=#FFC0CB>---[SCP049]---</color>\n<color=#FFC0CB>你一共3级多复活小僵尸吧qwq</color>", false);
            }
            if (ev.Player.GetRole() == RoleType.Scp079)
            {
                SCP079 = "SCP079";
            }
            if (ev.Player.GetRole() == RoleType.Scp096)
            {
                ev.Player.Broadcast(15, "<color=#FFC0CB>---[SCP096]---</color>\n<color=#00FFFF>HP:5000  </color>你拥有一种特殊能力\n<color=#FFD700>按E 3%概率 打开所有门</color>", false);
                SCP096 = "SCP096";
                s096 = 1;
                Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 1500)));
            }
            if (ev.Player.GetRole() == RoleType.Scp93989)
            {
                ev.Player.Broadcast(10, "<color=#FFC0CB>---[SCP939_89]---</color>\n<color=#00FFFF>HP:6000  </color>你拥有一种特殊能力\n受到<color=#FFD700>攻击时</color>你会加速,你可以奔跑", false);
                SCP939_89 = "SCP939_89";
                Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 6000)));

                s939_89 = 1;
            }
            if (ev.Player.GetRole() == RoleType.Scp93953)
            {
                ev.Player.Broadcast(10, "<color=#FFC0CB>---[SCP939_53]---</color>\n<color=#00FFFF>HP:6000  </color>你拥有一种特殊能力\n受到<color=#FFD700>攻击时</color>你会加速,你可以奔跑", false);
                SCP939_53 = "SCP939_53";
                s939_53 = 1;
                Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 6000)));

            }
            if (ev.Player.GetRole() == RoleType.Scp106)
            {
                ev.Player.Broadcast(10, "<color=#FFC0CB>---[SCP106]---</color>\n<color=#00FFFF>HP:650  </color>你拥有一种特殊能力\n受到<color=#FFD700>枪械伤害只有1点</color>", false);
                SCP106 = "SCP106";
                s106 = 1;
            }
            if (ev.Player.GetRole() == RoleType.Scp0492)
            {
                ev.Player.Broadcast(10, "<color=#FFC0CB>---[SCP049_2]---</color>\n<color=#00FFFF>HP:1400</color>", false);
                Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 1400)));

                xp += 50;
                if (xp == 100)
                {
                    lv = 1;
                }
                if (xp == 300)
                {
                    lv = 2;
                }
                if (xp == 700)
                {
                    lv = 3;
                }
                foreach (ReferenceHub player in Player.GetHubs())
                {
                    if (player.GetRole() == RoleType.Scp049)
                    {
                        player.AddHealth(150);
                        Setrank_new("当前等级:" + lv + " 经验值:" + xp, "pink", player);
                    }
                }
            }
            if(ev.Player.GetRole() == RoleType.ClassD)
            {
                Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 100)));

            }
        }
        public void OnPlayerSpawn(PlayerSpawnEvent ev)
        {

            starttimer = true;
            roundstart = true;
            if ((ev.Player.GetRole() == RoleType.Scp93989) && (new System.Random().Next(0, 100) <= 51))
            {
                Setrank_new("SCP-682", "red", ev.Player);
                scp682.Add(ev.Player.GetUserId());
                Log.Info(ev.Player.GetNickname() + "成为SCP682");
                Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 6000)));
            }
            if (ev.Player.GetRole() == RoleType.Scp93953)
            {
                Setrank_new("SCP-939-3", "red", ev.Player);
                ev.Player.Broadcast(10, "<color=#FF0000>你是SCP-939-3你攻击伤害为100点哦qwq</color>", false);
                Log.Info(ev.Player.GetNickname() + "939-3");
                scp939id = ev.Player.GetPlayerId();
                Coroutines.Add(Timing.RunCoroutine(RunRestoreMaxHp(ev.Player, 6000)));

            }
            if (ev.Player.GetRole() == RoleType.ChaosInsurgency)
            {
                ev.Player.Broadcast(10, "<color=#FFC0CB>[混沌分裂者]</color>\n<color=#00FFFF>你的任务是救出D级杀光九尾或与SCP合作</color>\n你对SCP造成的伤害<color=#FFD700>+5</color>", false);
                if(times2 == 4)
                {
                    hdjjs = ev.Player;
                    hdjjsid = ev.Player.GetPlayerId();
                    Setrank_new("混沌狙击手", "green", ev.Player);
                    times2 = 5;
                    Coroutines.Add(Timing.RunCoroutine(Hdjjs()));

                }
                if (times2 == 3)
                {
                    if(mzyes == false)
                    {
                        mz = ev.Player;
                        mzid = mz.GetPlayerId();
                        mzyes = true;
                        Coroutines.Add(Timing.RunCoroutine(Mzzb()));
                    }
                    times2 = 4;
                }
                if (times2 == 2)
                {
                    Map.Broadcast("SCP1143突破收容", 6, false);
                    scp1143 = ev.Player;
                    Setrank_new("SCP-1143", "red",  scp1143);
                    scp1143.Broadcast(6, "你是SCP1143 30秒会刷一个雷或闪光弹", false);
                    scp1143a = true;
                    scp1143id = scp1143.GetPlayerId();
                    Coroutines.Add(Timing.RunCoroutine(Giveboom()));
                    times2 = 3;
                }
                if ((times2 == 1))
                {
                    HDZHG = ev.Player;
                    times2 = 2;
                    Coroutines.Add(Timing.RunCoroutine(Hhzhgzb()));

                }

            }
            if ((ev.Player.GetRole() == RoleType.NtfCadet) && (jw.Contains(ev.Player.GetPlayerId())))
            {
                tiems++;
                if ((times == 7) && (jw.Contains(ev.Player.GetPlayerId())))
                {
                    if (scp550shuachu == false)
                    {
                        scp550 = ev.Player;
                        scp550id = scp550.GetPlayerId();
                        Coroutines.Add(Timing.RunCoroutine(Scp550item()));
                        scp550yes = true;
                        scp550shuachu = true;
                        jw.Remove(ev.Player.GetPlayerId());
                        scp550lv = 0;
                        scp550.SetRole(RoleType.Tutorial);
                        tssl = 0;
                    }
                }
                if ((times == 6) && (jw.Contains(ev.Player.GetPlayerId())))
                {
                    if (jwhngshuachu == false)
                    {
                        jwhng = ev.Player;
                        jwhngid = jwhng.GetPlayerId();
                        jwhngwufashanghai = true;
                        jwhngyes = true;
                        jw.Remove(ev.Player.GetPlayerId());
                        Coroutines.Add(Timing.RunCoroutine(Jwhngwufashanghai()));
                        Coroutines.Add(Timing.RunCoroutine(Jwhngitem()));
                    }
                }
                if ((times == 5) && (jw.Contains(ev.Player.GetPlayerId())))
                {
                    jwhhk = ev.Player;
                    jwhhkid = jwhhk.GetPlayerId();
                    jw.Remove(ev.Player.GetPlayerId());
                    Setrank_new("九尾狐黑客", "red", jwhhk);
                    jwhhk.Broadcast(5, "<color=lime>你是九尾狐黑客</color>:输入.hk可以黑入实验室", false);
                }
                if ((tiems == 4) && (bpb == false) && (jw.Contains(ev.Player.GetPlayerId())))
                {
                    bpb = true;
                    jw.Remove(ev.Player.GetPlayerId());
                    bpb2.Add(ev.Player.GetPlayerId());
                    Setrank_new("九尾狐爆破兵", "red", ev.Player);
                    ev.Player.Broadcast(5, "<color=red>你是九尾狐爆破兵</color>:捡起对讲机和闪光弹可以变成手雷", false);
                }
                if ((tiems == 3) && (scp073a == false) && (jw.Contains(ev.Player.GetPlayerId())))
                {
                    scp073 = ev.Player;
                    scp073a = true;
                    scp073id = scp073.GetPlayerId();
                    jw.Remove(ev.Player.GetPlayerId());
                    Setrank_new("SCP-073", "red", ev.Player);
                    ev.Player.Broadcast(5, "<color=#FF0000>你是九尾狐SCP-073</color>\n<color=lime>如果SCP攻击你 只有10点伤害 且反伤50 枪械攻击伤害为1且反伤5</color>", false);
                    scp073zb = false;
                }
                if ((tiems == 2) && (ylb1 == false) && (ev.Player.GetRole() == RoleType.NtfCadet) && (jw.Contains(ev.Player.GetPlayerId())))
                {
                    ylb1 = true;
                    Setrank_new("九尾医疗兵", "yellow", ev.Player);
                    ev.Player.Broadcast(5, "<color=#FF0000>你是九尾狐医疗兵</color>:在你周围的人会回血，捡起对讲机和闪光弹可以变成血包", false);
                    ylb = ev.Player;
                    ylb2.Add(ylb.GetUserId());
                    jw.Remove(ev.Player.GetPlayerId());
                }
                if ((tiems == 1) && (jw.Contains(ev.Player.GetPlayerId())))
                {
                    jw.Remove(ev.Player.GetPlayerId());
                    mrfish = ev.Player;
                    Setrank_new("Mr.Fish", "yellow", mrfish);
                    Map.Broadcast("<color=#FF0000>Mr.Fish:</color>你们太菜了看我把SCP都收容了", 10, false);
                    LLBS233.Add(mrfish.GetPlayerId());
                    Coroutines.Add(Timing.RunCoroutine(Mrfishzb()));

                }

                ev.Player.SetAmmo(AmmoType.Dropped5, 400);
                ev.Player.SetAmmo(AmmoType.Dropped7, 400);
                ev.Player.SetAmmo(AmmoType.Dropped9, 400);
            }
            if (ev.Player.GetRole() == RoleType.NtfCommander)
            {
                ev.Player.SetAmmo(AmmoType.Dropped5, 400);
                ev.Player.SetAmmo(AmmoType.Dropped7, 400);
                ev.Player.SetAmmo(AmmoType.Dropped9, 400);
                ev.Player.Broadcast(10, "<color=#FFC0CB>[九尾狐指挥官]</color>\n<color=#00FFFF>你可以给所有九尾狐阵营发送信息,冷却80秒</color>\n详细<color=#FFD700>按~键激活控制台输入.help查看帮助</color>", false);
            }
            if (ev.Player.GetRole() == RoleType.FacilityGuard)
            {
                ev.Player.SetAmmo(AmmoType.Dropped5, 400);
                ev.Player.SetAmmo(AmmoType.Dropped7, 400);
                ev.Player.SetAmmo(AmmoType.Dropped9, 400);
                ev.Player.Broadcast(10, "<color=#FFC0CB>[设施保安]</color>\n<color=#00FFFF>你的任务是捆绑救出D级科学家杀光SCP与混沌</color>\n你可以前往<color=#FFD700>逃脱点</color>获得物资", false);
            }
            if (ev.Player.GetRole() == RoleType.NtfLieutenant)
            {
                ev.Player.SetAmmo(AmmoType.Dropped5, 400);
                ev.Player.SetAmmo(AmmoType.Dropped7, 400);
                ev.Player.SetAmmo(AmmoType.Dropped9, 400);
            }

        }
        public void OnPlayerLeave(PlayerLeaveEvent ev)
        {
            if (ev.Player.GetPlayerId() == hdjjsid)
            {
                hdjjs = null;
                hdjjsid = 0;
            }
            if (小僵尸id.Contains(ev.Player.GetPlayerId()))
            {
                xp += 50;
                if (xp == 100)
                {
                    lv = 1;
                }
                if (xp == 350)
                {
                    lv = 2;
                }
                if (xp == 800)
                {
                    lv = 3;
                }
                foreach(ReferenceHub referenceHub in Player.GetHubs())
                {
                    if(referenceHub.GetRole() == RoleType.Scp049)
                    {
                        referenceHub.AddHealth(300);
                    }
                }
            }
            if(ev.Player.GetPlayerId() == Gears博士id)
            {
                Gears博士id = 0;
                Gears博士 = null;
            }
            if (ev.Player.GetPlayerId() == jwhhkid)
            {
                jwhng = null;
                jwhngyes = false;
                jwhngid = 0;
                jwhngwufashanghai = false;
                jwhngitem = true;
            }
            if (ev.Player.GetPlayerId() == scp035id)
            {
                scp035 = null;
                scp035id = 0;
                scp035goout = false;
                scp035yes = false;
            }
            if (ev.Player.GetPlayerId() == scp550id)
            {
                scp550id = 0;
                scp550yes = false;
                scp550 = null;
                scp550lv = 0;
                tssl = 0;
                Map.Broadcast("----[<color=#32CD32>[SCP550]</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + "掉线了" + "</color>", 6, false);

            }
            if (ev.Player.GetPlayerId() == hpszid)
            {
                hpsz = null;
                hpszid = 0;
            }
            if ((scp650yes == true) && (ev.Player.GetPlayerId() == scp650id))
            {
                scp650 = null;
                scp650id = 0;
                scp650yes = false;
                Map.Broadcast("----[<color=#32CD32>[SCP650]</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + "掉线了" + "</color>", 6, false);

            }
            if (ev.Player.GetPlayerId() == jwhhkid)
            {
                jwhhkid = 0;
                jwhhk = null;
            }
            if (ev.Player.GetPlayerId() == scp073id)
            {
                scp073 = null;
                scp073id = 0;
                Map.Broadcast("----[<color=#32CD32>SCP073</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + "掉线了" + "</color>", 6, false);

            }
            if (ev.Player.GetPlayerId() == scp076id)
            {
                scp076 = null;
                scp076id = 0;
                scp076yes = false;
                Map.Broadcast("----[<color=#32CD32>SCP076</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + "掉线了" + "</color>", 6, false);

            }
            if (ev.Player.GetPlayerId() == scp005aid)
            {
                scp005aid = 0;
            }
            if (ev.Player.GetPlayerId() == scp457id)
            {
                scp457 = null;
                scp457a = false;
                scp457die = true;
                scp457b = new Vector3();
                Setrank_new("white", "", ev.Player);
                scp457id = 0;
                Map.Broadcast("----[<color=#32CD32>SCP457</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + "掉线了" + "</color>", 6, false);

            }
            if (ev.Player.GetPlayerId() == xtdid)
            {
                xtd = null;
                xtdid = 0;
            }
            if ((qblcq2 == true) && (qblcq.GetPlayerId() == ev.Player.GetPlayerId()))
            {
                qblcq2 = false;
                qblcq = null;

            }
            if (scp682.Contains(ev.Player.GetUserId()))
            {
                scp682.Remove(ev.Player.GetUserId());
                Map.Broadcast("----[<color=#32CD32>SCP682</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + "掉线了" + "</color>", 6, false);

            }
            if (scp939id == ev.Player.GetPlayerId())
            {
                scp939id = 0;
            }
            if (ev.Player.GetPlayerId() == scp914mid)
            {
                scp914m = null;
                scp914mid = 0;
                Map.Broadcast("----[<color=#32CD32>SCP914-M</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + "掉线了" + "</color>", 6, false);
            }
            if (ev.Player.GetPlayerId() == scpqblid2)
            {
                scpqblid2 = 0;
                Map.Broadcast("----[<color=#32CD32>SCP乔碧萝</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + "掉线了" + "</color>", 6, false);

            }
            if (ev.Player.GetPlayerId() == scp181id)
            {
                scp181id = 0;
                Map.Broadcast("----[<color=#32CD32>SCP181</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + "掉线了" + "</color>", 6, false);
                Setrank_new("white", "", ev.Player);

            }
            if (ev.Player.GetPlayerId() == scp035id)
            {
                Map.Broadcast("----[<color=#32CD32>SCP035</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + "掉线了" + "</color>", 6, false);
                scp035 = null;
                scp035id = 0;
                scp035goout = false;
                scp035yes = false;
            }
            if (scp2006a.Contains(ev.Player.GetUserId()))
            {
                scp2006a.Clear();
                scp2006 = null;
                Map.Broadcast("----[<color=#32CD32>SCP2006</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + "掉线了" + "</color>", 6, false);
                Setrank_new("white", "", ev.Player);

            }
            if (ev.Player.GetPlayerId() == cxkid)
            {
                cxkid = 0;
                cxk = null;
                cxkyes = false;
                Map.Broadcast("----[<color=#32CD32>SCP蔡徐坤</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + "掉线了" + "</color>", 6, false);
                Setrank_new("white", "", ev.Player);

            }
            if (ev.Player.GetPlayerId() == scp817id)
            {
                scp817id = 0;
                scp817 = null;
                scp817yes = false;
                Map.Broadcast("----[<color=#32CD32>SCP817</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + "掉线了" + "</color>", 6, false);
                Setrank_new("white", "", ev.Player);

            }
            if (ev.Player.GetPlayerId() == D9341id)
            {
                if (times >= 5)
                {
                    D9341 = null;
                    D9341id = 0;
                    D9341Item = null;
                    D9341yes = false;
                    D9341zb = new Vector3();
                    Setrank_new("white", "", ev.Player);
                    Map.Broadcast("----[<color=#32CD32>D-9341</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + "掉线了" + "</color>", 6, false);

                }
            }
            if (bpb2.Contains(ev.Player.GetPlayerId()))
            {
                bpb = false;
                bpb2.Clear();
            }
            if (LLBS233.Contains(ev.Player.GetPlayerId()))
            {
                Map.Broadcast("<color=#FFFF33>Mr.fish:</color>\n装逼失败", 5, ev.Player);
                LLBS233.Remove(ev.Player.GetPlayerId());
                Setrank_new("white", "", ev.Player);

            }
            if (Dio2.Contains(ev.Player.GetUserId()))
            {
                Map.Broadcast("<color=#FFFF33>Dio:</color>\n装逼失败", 5, false);
                Dio2.Remove(ev.Player.GetUserId());
                Dio = null;
            }
            if (scp1143id == ev.Player.GetPlayerId())
            {
                scp1143 = null;
                scp1143id = 0;
                scp1143a = false;
                Map.Broadcast("----[<color=#32CD32>SCP1143</color>]----\n<color=#FF0000>[收容成功]</color>\n收容者: <color=#40E0D0>" + "掉线了" + "</color>", 6, false);

            }
            if (ylb2.Contains(ev.Player.GetUserId()))
            {
                ylb = null;
                ylb1 = false;
                ylb2.Clear();

            }
            if (ev.Player.GetPlayerId() == fkyyzid)
            {
                fkyyz = null;
                fkyyzid = 0;
                fkyyzyes = false;
                bindljf = false;
                bindtys = false;
                bindjzsj = false;
            }
            if (HDZHG2.Contains(ev.Player.GetUserId()))
            {
                HDZHG2.Remove(ev.Player.GetUserId());
            }
        }
    }
}