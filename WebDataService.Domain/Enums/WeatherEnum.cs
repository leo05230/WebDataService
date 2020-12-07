using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WebDataService.Domain.Enums
{
	public enum WEATHER
	{
		[Description("")]
		NONE,
		[Description("12小時降雨機率")]
		PoP12h,
		[Description("天氣現象")]
		Wx,
		[Description("體感溫度")]
		AT,
		[Description("溫度")]
		T,
		[Description("相對溼度")]
		RH,
		[Description("舒適度指數")]
		CI,
		[Description("天氣預報綜合描述")]
		WeatherDescription,
		[Description("風速")]
		WS,
		[Description("風向")]
		WD,
		[Description("露點溫度")]
		Td,
		[Description("6小時降雨機率")]
		PoP6h
	}
}
