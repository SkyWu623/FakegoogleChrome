using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace HuWikiAI
{
	internal class Program
	{
		private static string Path;

		private static async Task Main(string[] args)
		{
			Console.WriteLine("簡單AI助手已啟動！輸入'exit'退出程序");
			Console.WriteLine("胡維基 AI 3.5 聯網版已啟動！(支援聊天、翻譯、計算)");
			Console.WriteLine("==============================================");
			string[] positiveWords = new string[28]
			{
				"讚", "棒", "好", "開心", "喜歡", "優秀", "傑出", "卓越", "出色", "精采",
				"完美", "專業", "確實", "到位 ", "開心", "喜歡", "快樂", "愉悅", "興奮", "舒暢",
				"滿意", "溫暖", "感動", "欣慰", "踏實", "不錯", "厲害", "強"
			};
			string[] negativeWords = new string[6] { "爛", "差", "醜", "討厭", "生氣", "悲傷" };
			string[,] dm = new string[3, 4]
			{
				{ "七龍珠", "鬼滅之刃", "火影忍者", "高智能方程式" },
				{ "BLUE LOCK 藍色監獄", "進擊的巨人", "灌籃高手", "排球少年" },
				{ "哆啦A夢", "小豬珮琪", "旺旺隊", "波利" }
			};
			while (true)
			{
				Console.Write("胡維基 的AI: 今天有什么可以幫到你？\r\n  \t\t\t\t\t\t\t\t\t\t\t\t\t");
				string taxt = Console.ReadLine();
				string aitalk = "";
				if (taxt != "")
				{
					if (taxt.Contains("你好") || taxt.Contains("hi") || taxt.Contains("hello") || taxt.Contains("胡維基 的AI"))
					{
						aitalk = "你好！我是簡單的AI助手。";
					}
					else if (taxt.Contains("你叫什麼名字") || taxt.Contains("What your name"))
					{
						aitalk = "我是由C#編寫的簡單AI程序，名叫胡維基AI。\r\r如果想知更多關於ai的資訊可打關鍵字:AI、ai";
					}
					else if (taxt.Contains("AI") || taxt.Contains("ai"))
					{
						Path = "chat.json";
						aitalk = "";
						string jsontext = File.ReadAllText(Path);
						JArray json = new JArray(jsontext);
						foreach (JValue j in json)
						{
							aitalk = aitalk + "常見的ai有：" + (string)j["name"];
						}
						aitalk += "ai基本資訊以介紹完畢!";
					}
					else if (taxt.Contains("使用") || taxt.Contains("更新"))
					{
						string use = "使用方法.txt";
						aitalk = File.ReadAllText(use);
					}
					else if (taxt.Contains("紀錄") || taxt.Contains("以前"))
					{
						string use2 = "chat_history.txt";
						aitalk = File.ReadAllText(use2);
					}
					else if (taxt.Contains("笑") || taxt.Contains("笑話"))
					{
						string en = "C:\\Users\\Surface\\Desktop\\胡維基 的AI\\剪刀石頭布\\剪刀石頭布\\笑話.txt";
						aitalk = File.ReadAllText(en);
						Console.WriteLine("-------------講笑話---------------");
					}
					else if (taxt.Contains("動漫") || taxt.Contains("卡通"))
					{
						aitalk = "\r\n--- 推薦清單 ---\r\n";
						for (int i = 0; i < 3; i++)
						{
							for (int k = 0; k < 4; k++)
							{
								aitalk = aitalk + "[" + dm[i, k] + "] ";
							}
							aitalk += "\r\n";
						}
					}
					else if (taxt.Contains("天氣"))
					{
						aitalk = "我不知道天氣，但今天是個好日子！";
					}
					else if (taxt.Contains("註冊"))
					{
						Console.WriteLine("輸入帳號");
						string account = Console.ReadLine();
						Console.WriteLine("確認帳號");
						string acc = Console.ReadLine();
						if (account == acc)
						{
							aitalk = "註冊成功";
							File.WriteAllText("pross.txt", account);
						}
						else
						{
							aitalk = "註冊失敗";
						}
					}
					else if (taxt.Contains("登入"))
					{
						Console.WriteLine("請輸入帳號");
						string acc2 = Console.ReadLine();
						string pross = "pross.txt";
						string p = File.ReadAllText(pross);
						if (acc2 == p)
						{
							aitalk = acc2 + "歡迎進入\r\n現在我變聰明了!";
						}
					}
					else if (taxt.Contains("時間") || taxt.Contains("幾點"))
					{
						aitalk = $"現在時間是: {DateTime.Now:HH:mm}";
					}
					else if (taxt.Contains("日期") || taxt.Contains("幾月幾日"))
					{
						aitalk = $"今天是: {DateTime.Now:ddddyyyy年MM月dd日}";
					}
					else if (taxt.Contains("計算"))
					{
						Console.WriteLine("我可以幫你計算。");
						Console.WriteLine("請輸入第一個要計算的數");
						double num1 = Convert.ToDouble(Console.ReadLine());
						Console.WriteLine("請輸入運算子");
						string a = Console.ReadLine();
						Console.WriteLine("請輸入第二個要計算的數");
						double num2 = Convert.ToDouble(Console.ReadLine());
						math(num1, a, num2);
					}
					else if (taxt.Contains("謝謝") || taxt.Contains("thank"))
					{
						aitalk = "不客气！很高興能幫助到你";
					}
					else if (taxt.Contains("再见") || taxt.Contains("bye"))
					{
						aitalk = "再见！祝你今天愉快！";
					}
					else
					{
						if (taxt.Contains("exit"))
						{
							break;
						}
						if (taxt.Contains("樂透"))
						{
							aitalk = "開啟樂透";
							Process.Start("C:\\Users\\Surface\\Desktop\\第56屆全國技能競賽分區技能競賽\\CSA03\\CSA03\\bin\\Debug\\CSA03");
						}
						else
						{
							string[] isee = new string[6] { "這個問题很有趣，但我還需要學習更多才能回答。", "我不太明白，能換個方式問嗎？", "我正在學習如何更好地回答这个問題。", "聽起来很有意思！", "讓我想想... 嗯，这是個好問題。", "讓我查一下資料...啊，還沒學到這個。" };
							Random random = new Random();
							int index = random.Next(isee.Length);
							aitalk = isee[index];
							_ = taxt;
							if (taxt.Contains("翻譯"))
							{
								_ = "請將以下文字翻譯成英文（如果是英文則翻譯成中文）：" + taxt;
							}
						}
					}
					Console.WriteLine("胡維基 的AI:" + aitalk);
					int score = 0;
					score += positiveWords.Count((string w) => taxt.Contains(w));
					score -= negativeWords.Count((string w) => taxt.Contains(w));
					if (score > 0)
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("AI 情緒判斷：\ud83d\ude0a 這聽起來很正向！");
						Console.ForegroundColor = ConsoleColor.White;
					}
					else if (score < 0)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("AI 情緒判斷：\ud83d\ude21 感覺你在發脾氣喔。\r\nAre you ok?");
						Console.ForegroundColor = ConsoleColor.White;
					}
					else
					{
						Console.WriteLine("AI 情緒判斷：\ud83d\ude10 沒什麼感覺，稀鬆平常。");
					}
				}
				else
				{
					Console.WriteLine("請輸入字串");
				}
				Savechat(taxt, aitalk);
			}
			Console.Write("胡維基 的AI: 再見！");
		}

		private static void Savechat(string user, string ai)
		{
			string timestamp = DateTime.Now.ToString("yyyy-MM-dd- HH:mm");
			string record = "[" + timestamp + "] 你: " + user + "\n[" + timestamp + "] AI: " + ai + "\n" + new string('_', 30);
			Path = "chat_history.txt";
			File.AppendAllText(Path, record + Environment.NewLine);
		}

		private static string math(double num1, string a, double num2)
		{
			switch (a)
			{
			case "+":
				Console.WriteLine($"{num1}+{num2}={num1 + num2}");
				return $"計算結果為{num1 + num2}";
			case "-":
				Console.WriteLine($"{num1}-{num2}={num1 - num2}");
				return $"計算結果為{num1 - num2}";
			case "*":
				Console.WriteLine($"{num1}*{num2}={num1 * num2}");
				return $"計算結果為{num1 * num2}";
			case "/":
				Console.WriteLine($"{num1}/{num2}={num1 / num2}");
				return $"計算結果為{num1 / num2}";
			default:
				return "錯誤";
			}
		}
	}
}
