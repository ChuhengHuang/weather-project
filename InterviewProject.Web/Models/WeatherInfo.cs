using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Models
{
	/*----------
	 * {"consolidated_weather":
	[
		{
			"id":5740734076420096,
			"weather_state_name":"Heavy Rain",
			"weather_state_abbr":"hr",
			"wind_direction_compass":"SW",
			"created":"2020-02-16T18:16:02.208046Z",
			"applicable_date":"2020-02-16",
			"min_temp":5.995,
			"max_temp":10.25,
			"the_temp":9.945,
			"wind_speed":11.708718873785095,
			"wind_direction":227.33275372808097,
			"air_pressure":993.5,
			"humidity":80,
			"visibility":5.226663783504335,
			"predictability":77},
			
		{"id":5177784122998784,"weather_state_name":"Light Rain","weather_state_abbr":"lr","wind_direction_compass":"WSW","created":"2020-02-16T18:16:02.605249Z","applicable_date":"2020-02-17","min_temp":5.39,"max_temp":9.725,"the_temp":9.405000000000001,"wind_speed":12.150906583920571,"wind_direction":236.3513679197887,"air_pressure":1009.0,"humidity":59,"visibility":12.939123021554124,"predictability":75},
		{"id":5576162203926528,"weather_state_name":"Showers","weather_state_abbr":"s","wind_direction_compass":"WSW","created":"2020-02-16T18:16:02.412303Z","applicable_date":"2020-02-18","min_temp":4.59,"max_temp":9.625,"the_temp":9.145,"wind_speed":12.20572219917018,"wind_direction":244.8358390860205,"air_pressure":1019.0,"humidity":63,"visibility":12.739041497653702,"predictability":73},
		
		{"id":5535613912612864,"weather_state_name":"Light Rain","weather_state_abbr":"lr","wind_direction_compass":"WSW","created":"2020-02-16T18:16:02.209023Z","applicable_date":"2020-02-19","min_temp":3.715,"max_temp":9.09,"the_temp":8.17,"wind_speed":8.866564391929797,"wind_direction":253.16436608318753,"air_pressure":1021.5,"humidity":65,"visibility":11.799528254990854,"predictability":75},
		{"id":5617210816987136,"weather_state_name":"Heavy Rain","weather_state_abbr":"hr","wind_direction_compass":"SW","created":"2020-02-16T18:16:02.528845Z","applicable_date":"2020-02-20","min_temp":4.550000000000001,"max_temp":11.045,"the_temp":10.620000000000001,"wind_speed":13.869433333890084,"wind_direction":223.6734582403695,"air_pressure":1007.5,"humidity":76,"visibility":8.855160860574246,"predictability":77},
		{"id":6306670667890688,"weather_state_name":"Heavy Cloud","weather_state_abbr":"hc","wind_direction_compass":"WSW","created":"2020-02-16T18:16:04.805266Z","applicable_datewind_direction":242.5,"air_pressure":1025.0,"humidity":62,"visibility":9.999726596675416,"predictability":71}":"2020-02-21","min_temp":3.8149999999999995,"max_temp":10.5,"the_temp":9.13,"wind_speed":9.592523065298655,"
	],
"time":"2020-02-16T18:30:01.942433Z"
,"sun_rise":"2020-02-16T07:13:35.337034Z",
"sun_set":"2020-02-16T17:16:22.919932Z",
"timezone_name":"LMT",
"parent":{"title":"England","location_type":"Region / State / Province","woeid":24554868,"latt_long":"52.883560,-1.974060"},
"sources":[{"title":"BBC","slug":"bbc","url":"http://www.bbc.co.uk/weather/","crawl_rate":360},{"title":"Forecast.io","slug":"forecast-io","url":"http://forecast.io/","crawl_rate":480},{"title":"HAMweather","slug":"hamweather","url":"http://www.hamweather.com/","crawl_rate":360},{"title":"Met Office","slug":"met-office","url":"http://www.metoffice.gov.uk/","crawl_rate":180},{"title":"OpenWeatherMap","slug":"openweathermap","url":"http://openweathermap.org/","crawl_rate":360},{"title":"Weather Underground","slug":"wunderground","url":"https://www.wunderground.com/?apiref=fc30dc3cd224e19b","crawl_rate":720},{"title":"World Weather Online","slug":"world-weather-online","url":"http://www.worldweatheronline.com/","crawl_rate":360}],
"title":"London",
"location_type":"City",
"woeid":44418,
"latt_long":"51.506321,-0.12714",
"timezone":"Europe/London"}
	 * ---------
	 */
	public class WeatherInfo
	{

		public List<ConsolidatedWeather> Consolidated_Weather { get; set; }

		public DateTime Time { get; set; }

		public string Title { get; set; }

		public string Location_Type { get; set; }

		public int Woeid { get; set; }

		public string Latt_Long { get; set; }

		public string Timezone { get; set; }

	}

	public class ConsolidatedWeather
	{

		public long Id { get; set; }

		public string Applicable_Date { get; set; }

		public decimal Min_Temp { get; set; }

		public decimal Max_Temp { get; set; }

		public decimal The_Temp { get; set; }

		public int Humidity { get; set; }

		public int Predictability { get; set; }

	}
}
