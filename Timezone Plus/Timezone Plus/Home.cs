using Newtonsoft.Json.Linq;
using RestSharp;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Timezone_Plus
{
    public partial class Home : Form
    {
        [StructLayout(LayoutKind.Sequential)]
        internal struct SYSTEMTIME
        {
            public ushort wYear;
            public ushort wMonth;
            public ushort wDayOfWeek;    // ignored for the SetLocalTime function
            public ushort wDay;
            public ushort wHour;
            public ushort wMinute;
            public ushort wSecond;
            public ushort wMilliseconds;
        }
        IPController _controller;
        JArray JsonTimeZone;
        Dictionary<string, string> timezoneWindowns = new Dictionary<string, string>()
        {
            {"(UTC-12:00) International Date Line West", "Dateline Standard Time"},
            {"(UTC-11:00) Coordinated Universal Time-11", "UTC-11"},
            {"(UTC-10:00) Aleutian Islands", "Aleutian Standard Time"},
            {"(UTC-10:00) Hawaii", "Hawaiian Standard Time"},
            {"(UTC-09:30) Marquesas Islands", "Marquesas Standard Time"},
            {"(UTC-09:00) Alaska", "Alaskan Standard Time"},
            {"(UTC-09:00) Coordinated Universal Time-09", "UTC-09"},
            {"(UTC-08:00) Baja California", "Pacific Standard Time (Mexico)"},
            {"(UTC-08:00) Coordinated Universal Time-08", "UTC-08"},
            {"(UTC-08:00) Pacific Time(US & Canada)", "Pacific Standard Time"},
            {"(UTC-07:00) Arizona", "US Mountain Standard Time"},
            {"(UTC-07:00) Chihuahua, La Paz, Mazatlan", "Mountain Standard Time (Mexico)"},
            {"(UTC-07:00) Mountain Time(US & Canada)", "Mountain Standard Time"},
            {"(UTC-07:00) Yukon", "Yukon Standard Time"},
            {"(UTC-06:00) Central America", "Central America Standard Time"},
            {"(UTC-06:00) Central Time(US & Canada)", "Central Standard Time"},
            {"(UTC-06:00) Easter Island", "Easter Island Standard Time"},
            {"(UTC-06:00) Guadalajara, Mexico City, Monterrey", "Central Standard Time (Mexico)"},
            {"(UTC-06:00) Saskatchewan", "Canada Central Standard Time"},
            {"(UTC-05:00) Bogota, Lima, Quito, Rio Branco", "SA Pacific Standard Time"},
            {"(UTC-05:00) Chetumal", "Eastern Standard Time (Mexico)"},
            {"(UTC-05:00) Eastern Time(US & Canada)", "Eastern Standard Time"},
            {"(UTC-05:00) Haiti", "Haiti Standard Time"},
            {"(UTC-05:00) Havana", "Cuba Standard Time"},
            {"(UTC-05:00) Indiana(East)", "US Eastern Standard Time"},
            {"(UTC-05:00) Turks and Caicos", "Turks And Caicos Standard Time"},
            {"(UTC-04:00) Asuncion", "Paraguay Standard Time"},
            {"(UTC-04:00) Atlantic Time(Canada)", "Atlantic Standard Time"},
            {"(UTC-04:00) Caracas", "Venezuela Standard Time"},
            {"(UTC-04:00) Cuiaba", "Central Brazilian Standard Time"},
            {"(UTC-04:00) Georgetown, La Paz, Manaus, San Juan", "SA Western Standard Time"},
            {"(UTC-04:00) Santiago", "Pacific SA Standard Time"},
            {"(UTC-03:30) Newfoundland", "Newfoundland Standard Time"},
            {"(UTC-03:00) Araguaina", "Tocantins Standard Time"},
            {"(UTC-03:00) Brasilia", "E.South America Standard Time"},
            {"(UTC-03:00) Cayenne, Fortaleza", "SA Eastern Standard Time"},
            {"(UTC-03:00) City of Buenos Aires", "Argentina Standard Time"},
            {"(UTC-03:00) Greenland", "Greenland Standard Time"},
            {"(UTC-03:00) Montevideo", "Montevideo Standard Time"},
            {"(UTC-03:00) Punta Arenas", "Magallanes Standard Time"},
            {"(UTC-03:00) Saint Pierre and Miquelon", "Saint Pierre Standard Time"},
            {"(UTC-03:00) Salvador", "Bahia Standard Time"},
            {"(UTC-02:00) Coordinated Universal Time-02", "UTC-02"},
            {"(UTC-01:00) Azores", "Azores Standard Time"},
            {"(UTC-01:00) Cabo Verde Is.", "Cape Verde Standard Time"},
            {"(UTC) Coordinated Universal Time", "UTC"},
            {"(UTC+00:00) Dublin, Edinburgh, Lisbon, London", "GMT Standard Time"},
            {"(UTC+00:00) Monrovia, Reykjavik", "Greenwich Standard Time"},
            {"(UTC+00:00) Sao Tome", "Sao Tome Standard Time"},
            {"(UTC+01:00) Casablanca", "Morocco Standard Time"},
            {"(UTC+01:00) Amsterdam, Berlin, Bern, Rome, Stockholm, Vienna", "W.Europe Standard Time"},
            {"(UTC+01:00) Belgrade, Bratislava, Budapest, Ljubljana, Prague", "Central Europe Standard Time"},
            {"(UTC+01:00) Brussels, Copenhagen, Madrid, Paris", "Romance Standard Time"},
            {"(UTC+01:00) Sarajevo, Skopje, Warsaw, Zagreb", "Central European Standard Time"},
            {"(UTC+01:00) West Central Africa", "W. Central Africa Standard Time"},
            {"(UTC+02:00) Amman", "Jordan Standard Time"},
            {"(UTC+02:00) Athens, Bucharest", "GTB Standard Time"},
            {"(UTC+02:00) Beirut", "Middle East Standard Time"},
            {"(UTC+02:00) Cairo", "Egypt Standard Time"},
            {"(UTC+02:00) Chisinau", "E.Europe Standard Time"},
            {"(UTC+02:00) Damascus", "Syria Standard Time"},
            {"(UTC+02:00) Gaza, Hebron", "West Bank Standard Time"},
            {"(UTC+02:00) Harare, Pretoria", "South Africa Standard Time"},
            {"(UTC+02:00) Helsinki, Kyiv, Riga, Sofia, Tallinn, Vilnius", "FLE Standard Time"},
            {"(UTC+02:00) Jerusalem", "Israel Standard Time"},
            {"(UTC+02:00) Juba", "South Sudan Standard Time"},
            {"(UTC+02:00) Kaliningrad", "Kaliningrad Standard Time"},
            {"(UTC+02:00) Khartoum", "Sudan Standard Time"},
            {"(UTC+02:00) Tripoli", "Libya Standard Time"},
            {"(UTC+02:00) Windhoek", "Namibia Standard Time"},
            {"(UTC+03:00) Baghdad", "Arabic Standard Time"},
            {"(UTC+03:00) Istanbul", "Turkey Standard Time"},
            {"(UTC+03:00) Kuwait, Riyadh", "Arab Standard Time"},
            {"(UTC+03:00) Minsk", "Belarus Standard Time"},
            {"(UTC+03:00) Moscow, St.Petersburg", "Russian Standard Time"},
            {"(UTC+03:00) Nairobi", "E.Africa Standard Time"},
            {"(UTC+03:00) Volgograd", "Volgograd Standard Time"},
            {"(UTC+03:30) Tehran", "Iran Standard Time"},
            {"(UTC+04:00) Abu Dhabi, Muscat", "Arabian Standard Time"},
            {"(UTC+04:00) Astrakhan, Ulyanovsk", "Astrakhan Standard Time"},
            {"(UTC+04:00) Baku", "Azerbaijan Standard Time"},
            {"(UTC+04:00) Izhevsk, Samara", "Russia Time Zone 3"},
            {"(UTC+04:00) Port Louis", "Mauritius Standard Time"},
            {"(UTC+04:00) Saratov", "Saratov Standard Time"},
            {"(UTC+04:00) Tbilisi", "Georgian Standard Time"},
            {"(UTC+04:00) Yerevan", "Caucasus Standard Time"},
            {"(UTC+04:30) Kabul", "Afghanistan Standard Time"},
            {"(UTC+05:00) Ashgabat, Tashkent", "West Asia Standard Time"},
            {"(UTC+05:00) Ekaterinburg", "Ekaterinburg Standard Time"},
            {"(UTC+05:00) Islamabad, Karachi", "Pakistan Standard Time"},
            {"(UTC+05:00) Qyzylorda", "Qyzylorda Standard Time"},
            {"(UTC+05:30) Chennai, Kolkata, Mumbai, New Delhi", "India Standard Time"},
            {"(UTC+05:30) Sri Jayawardenepura", "Sri Lanka Standard Time"},
            {"(UTC+05:45) Kathmandu", "Nepal Standard Time"},
            {"(UTC+06:00) Astana", "Central Asia Standard Time"},
            {"(UTC+06:00) Dhaka", "Bangladesh Standard Time"},
            {"(UTC+06:00) Omsk", "Omsk Standard Time"},
            {"(UTC+06:30) Yangon(Rangoon)", "Myanmar Standard Time"},
            {"(UTC+07:00) Bangkok, Hanoi, Jakarta", "SE Asia Standard Time"},
            {"(UTC+07:00) Barnaul, Gorno - Altaysk", "Altai Standard Time"},
            {"(UTC+07:00) Hovd", "W.Mongolia Standard Time"},
            {"(UTC+07:00) Krasnoyarsk", "North Asia Standard Time"},
            {"(UTC+07:00) Novosibirsk", "N.Central Asia Standard Time"},
            {"(UTC+07:00) Tomsk", "Tomsk Standard Time"},
            {"(UTC+08:00) Beijing, Chongqing, Hong Kong, Urumqi", "China Standard Time"},
            {"(UTC+08:00) Irkutsk", "North Asia East Standard Time"},
            {"(UTC+08:00) Kuala Lumpur, Singapore", "Singapore Standard Time"},
            {"(UTC+08:00) Perth", "W.Australia Standard Time"},
            {"(UTC+08:00) Taipei", "Taipei Standard Time"},
            {"(UTC+08:00) Ulaanbaatar", "Ulaanbaatar Standard Time"},
            {"(UTC+08:45) Eucla", "Aus Central W. Standard Time"},
            {"(UTC+09:00) Chita", "Transbaikal Standard Time"},
            {"(UTC+09:00) Osaka, Sapporo, Tokyo", "Tokyo Standard Time"},
            {"(UTC+09:00) Pyongyang", "North Korea Standard Time"},
            {"(UTC+09:00) Seoul", "Korea Standard Time"},
            {"(UTC+09:00) Yakutsk", "Yakutsk Standard Time"},
            {"(UTC+09:30) Adelaide", "Cen.Australia Standard Time"},
            {"(UTC+09:30) Darwin", "AUS Central Standard Time"},
            {"(UTC+10:00) Brisbane", "E.Australia Standard Time"},
            {"(UTC+10:00) Canberra, Melbourne, Sydney", "AUS Eastern Standard Time"},
            {"(UTC+10:00) Guam, Port Moresby", "West Pacific Standard Time"},
            {"(UTC+10:00) Hobart", "Tasmania Standard Time"},
            {"(UTC+10:00) Vladivostok", "Vladivostok Standard Time"},
            {"(UTC+10:30) Lord Howe Island", "Lord Howe Standard Time"},
            {"(UTC+11:00) Bougainville Island", "Bougainville Standard Time"},
            {"(UTC+11:00) Chokurdakh", "Russia Time Zone 10"},
            {"(UTC+11:00) Magadan", "Magadan Standard Time"},
            {"(UTC+11:00) Norfolk Island", "Norfolk Standard Time"},
            {"(UTC+11:00) Sakhalin", "Sakhalin Standard Time"},
            {"(UTC+11:00) Solomon Is., New Caledonia", "Central Pacific Standard Time"},
            {"(UTC+12:00) Anadyr, Petropavlovsk - Kamchatsky", "Russia Time Zone 11"},
            {"(UTC+12:00) Auckland, Wellington", "New Zealand Standard Time"},
            {"(UTC+12:00) Coordinated Universal Time+12", "UTC+12"},
            {"(UTC+12:00) Fiji", "Fiji Standard Time"},
            {"(UTC+12:45) Chatham Islands", "Chatham Islands Standard Time"},
            {"(UTC+13:00) Coordinated Universal Time+13", "UTC+13"},
            {"(UTC+13:00) Nuku 'alofa", "Tonga Standard Time"},
            {"(UTC+13:00) Samoa", "Samoa Standard Time"},
            {"(UTC+14:00) Kiritimati Island", "Line Islands Standard Time"},
        };
        public Home()
        {
            InitializeComponent();
            _controller = new IPController();
            readFileJson();
        }

        public void readFileJson()
        {
            JsonTimeZone = JArray.Parse(File.ReadAllText("timezones.json"));
        }
        public void getIp()
        {
            var client = new RestClient("https://demo.ip-api.com/json/?fields=66842623&lang=en");
            client.Timeout = 30000;
            var request = new RestRequest(Method.GET);
            client.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:100.0) Gecko/20100101 Firefox/100.0";
            request.AddHeader("Accept", "*/*");
            request.AddHeader("Accept-Language", "en-US,en;q=0.5");
            request.AddHeader("Accept-Encoding", "gzip, deflate, br");
            request.AddHeader("Origin", "https://ip-api.com");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Referer", "https://ip-api.com/");
            request.AddHeader("Sec-Fetch-Dest", "empty");
            request.AddHeader("Sec-Fetch-Mode", "cors");
            request.AddHeader("Sec-Fetch-Site", "same-site");
            IRestResponse response = client.Execute(request);
            if(string.IsNullOrEmpty(response.Content))
            {
                MessageBox.Show("Không có kết nối. Hãy thử đổi IP khác");
                return;
            }
            try
            {
                JObject json = JObject.Parse(response.Content);
                txtIP.Text = json.ToString();
                _controller.ip = json["query"].ToString();
                _controller.country = json["country"].ToString();
                _controller.region = json["regionName"].ToString();
                _controller.city = json["city"].ToString();
                _controller.district = json["district"].ToString();
                _controller.zipcode = json["zip"].ToString();
                _controller.latitude = json["lat"].ToString();
                _controller.longitude = json["lon"].ToString();
                _controller.timezone = json["timezone"].ToString();
                _controller.ips = json["isp"].ToString();              
            }
            catch (Exception e) {
                MessageBox.Show("Đã xảy ra lỗi");
            }
        }
        public void changerTimeZone()
        {
            getIp();
            if (!String.IsNullOrEmpty(_controller.timezone))
            {
                foreach (JObject json in JsonTimeZone)
                {
                    JArray utcArray = JArray.Parse(json["utc"].ToString());
                    foreach (String utc in utcArray)
                    {
                        if (utc.Contains(_controller.timezone))
                        {
                            string valueTime = json["value"].ToString();
                            foreach (KeyValuePair<String, String> item in timezoneWindowns)
                            {
                                if (item.Value.Contains(valueTime))
                                {
                                    SetSystemTimeZone(valueTime);
                                }
                            }
                        }
                    }
                }
            }
        }

        public void SetSystemTimeZone(string timeZoneId)
        {
            var process = Process.Start(new ProcessStartInfo
            {
                FileName = "tzutil.exe",
                Arguments = "/s \"" + timeZoneId + "\"",
                UseShellExecute = false,
                CreateNoWindow = true
            });

            if (process != null)
            {
                process.WaitForExit();
                TimeZoneInfo.ClearCachedData();
            }
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool SetLocalTime(ref SYSTEMTIME lpSystemTime);
        private void txtcheckip_Click(object sender, EventArgs e)
        {
            var uri = "https://ip-score.com/";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }

        private void lostCancelButton1_Click(object sender, EventArgs e)
        {
            getIp();
            var uri = "https://www.ipqualityscore.com/free-ip-lookup-proxy-vpn-test/lookup/" + _controller.ip;
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }

        public void getTimeFromTimeZone(string timezone)
        {
            var client = new RestClient("http://worldtimeapi.org/api/timezone/" + timezone);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            try
            {
                JObject json = JObject.Parse(response.Content);
                DateTime dateTime = DateTime.Parse(json["datetime"].ToString());
             
                SYSTEMTIME timesystem = new SYSTEMTIME();
                timesystem.wDay = (ushort) dateTime.Day;
                timesystem.wMonth = (ushort)dateTime.Month;
                timesystem.wYear = (ushort)dateTime.Year;
                timesystem.wHour = (ushort)dateTime.Hour;
                timesystem.wMinute = (ushort)dateTime.Minute;
                var result = SetLocalTime(ref timesystem);
                if(result == false)
                {
                    MessageBox.Show("Thất bại. Vui lòng chạy ứng dụng ở quyền Admin", "Notify");
                }
                else
                {
                    MessageBox.Show("Thành công", "Notify");
                }
                
            }
            catch (Exception e) {
                MessageBox.Show("Đã xảy ra lỗi");
            }
      

        }
        private void lostAcceptButton2_Click(object sender, EventArgs e)
        {
            txtIP.Text = "Vui lòng chờ...";
            changerTimeZone();
            if (!string.IsNullOrEmpty(_controller.timezone))
            {
                getTimeFromTimeZone(_controller.timezone);
            }       
        }
    }
}
