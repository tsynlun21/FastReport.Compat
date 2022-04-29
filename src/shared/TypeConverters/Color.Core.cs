﻿#if NETSTANDARD2_0 || NETSTANDARD2_1
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace System.Drawing
{
    #if NETSTANDARD2_0 && !SKIA
    public enum KnownColor
    {
        ActiveBorder = 1,
        ActiveCaption = 2,
        ActiveCaptionText = 3,
        AppWorkspace = 4,
        Control = 5,
        ControlDark = 6,
        ControlDarkDark = 7,
        ControlLight = 8,
        ControlLightLight = 9,
        ControlText = 10,
        Desktop = 11,
        GrayText = 12,
        Highlight = 13,
        HighlightText = 14,
        HotTrack = 15,
        InactiveBorder = 16,
        InactiveCaption = 17,
        InactiveCaptionText = 18,
        Info = 19,
        InfoText = 20,
        Menu = 21,
        MenuText = 22,
        ScrollBar = 23,
        Window = 24,
        WindowFrame = 25,
        WindowText = 26,
        Transparent = 27,
        AliceBlue = 28,
        AntiqueWhite = 29,
        Aqua = 30,
        Aquamarine = 31,
        Azure = 32,
        Beige = 33,
        Bisque = 34,
        Black = 35,
        BlanchedAlmond = 36,
        Blue = 37,
        BlueViolet = 38,
        Brown = 39,
        BurlyWood = 40,
        CadetBlue = 41,
        Chartreuse = 42,
        Chocolate = 43,
        Coral = 44,
        CornflowerBlue = 45,
        Cornsilk = 46,
        Crimson = 47,
        Cyan = 48,
        DarkBlue = 49,
        DarkCyan = 50,
        DarkGoldenrod = 51,
        DarkGray = 52,
        DarkGreen = 53,
        DarkKhaki = 54,
        DarkMagenta = 55,
        DarkOliveGreen = 56,
        DarkOrange = 57,
        DarkOrchid = 58,
        DarkRed = 59,
        DarkSalmon = 60,
        DarkSeaGreen = 61,
        DarkSlateBlue = 62,
        DarkSlateGray = 63,
        DarkTurquoise = 64,
        DarkViolet = 65,
        DeepPink = 66,
        DeepSkyBlue = 67,
        DimGray = 68,
        DodgerBlue = 69,
        Firebrick = 70,
        FloralWhite = 71,
        ForestGreen = 72,
        Fuchsia = 73,
        Gainsboro = 74,
        GhostWhite = 75,
        Gold = 76,
        Goldenrod = 77,
        Gray = 78,
        Green = 79,
        GreenYellow = 80,
        Honeydew = 81,
        HotPink = 82,
        IndianRed = 83,
        Indigo = 84,
        Ivory = 85,
        Khaki = 86,
        Lavender = 87,
        LavenderBlush = 88,
        LawnGreen = 89,
        LemonChiffon = 90,
        LightBlue = 91,
        LightCoral = 92,
        LightCyan = 93,
        LightGoldenrodYellow = 94,
        LightGray = 95,
        LightGreen = 96,
        LightPink = 97,
        LightSalmon = 98,
        LightSeaGreen = 99,
        LightSkyBlue = 100,
        LightSlateGray = 101,
        LightSteelBlue = 102,
        LightYellow = 103,
        Lime = 104,
        LimeGreen = 105,
        Linen = 106,
        Magenta = 107,
        Maroon = 108,
        MediumAquamarine = 109,
        MediumBlue = 110,
        MediumOrchid = 111,
        MediumPurple = 112,
        MediumSeaGreen = 113,
        MediumSlateBlue = 114,
        MediumSpringGreen = 115,
        MediumTurquoise = 116,
        MediumVioletRed = 117,
        MidnightBlue = 118,
        MintCream = 119,
        MistyRose = 120,
        Moccasin = 121,
        NavajoWhite = 122,
        Navy = 123,
        OldLace = 124,
        Olive = 125,
        OliveDrab = 126,
        Orange = 127,
        OrangeRed = 128,
        Orchid = 129,
        PaleGoldenrod = 130,
        PaleGreen = 131,
        PaleTurquoise = 132,
        PaleVioletRed = 133,
        PapayaWhip = 134,
        PeachPuff = 135,
        Peru = 136,
        Pink = 137,
        Plum = 138,
        PowderBlue = 139,
        Purple = 140,
        Red = 141,
        RosyBrown = 142,
        RoyalBlue = 143,
        SaddleBrown = 144,
        Salmon = 145,
        SandyBrown = 146,
        SeaGreen = 147,
        SeaShell = 148,
        Sienna = 149,
        Silver = 150,
        SkyBlue = 151,
        SlateBlue = 152,
        SlateGray = 153,
        Snow = 154,
        SpringGreen = 155,
        SteelBlue = 156,
        Tan = 157,
        Teal = 158,
        Thistle = 159,
        Tomato = 160,
        Turquoise = 161,
        Violet = 162,
        Wheat = 163,
        White = 164,
        WhiteSmoke = 165,
        Yellow = 166,
        YellowGreen = 167,
        ButtonFace = 168,
        ButtonHighlight = 169,
        ButtonShadow = 170,
        GradientActiveCaption = 171,
        GradientInactiveCaption = 172,
        MenuBar = 173,
        MenuHighlight = 174
    }
#endif
    public class ColorExt
    {
        private static readonly ConcurrentDictionary<int, KnownColor> ColorToKnownColor = new ConcurrentDictionary<int, KnownColor>();
        private static readonly ConcurrentDictionary<KnownColor, Color> KnownColorToColor = new ConcurrentDictionary<KnownColor, Color>();

        static ColorExt()
        {
            ColorToKnownColor[-4934476] = KnownColor.ActiveBorder;
            KnownColorToColor[KnownColor.ActiveBorder] = Color.FromArgb(-4934476);
            ColorToKnownColor[-6703919] = KnownColor.ActiveCaption;
            KnownColorToColor[KnownColor.ActiveCaption] = Color.FromArgb(-6703919);
            ColorToKnownColor[-16777216] = KnownColor.ActiveCaptionText;
            KnownColorToColor[KnownColor.ActiveCaptionText] = Color.FromArgb(-16777216);
            ColorToKnownColor[-5526613] = KnownColor.AppWorkspace;
            KnownColorToColor[KnownColor.AppWorkspace] = Color.FromArgb(-5526613);
            ColorToKnownColor[-986896] = KnownColor.Control;
            KnownColorToColor[KnownColor.Control] = Color.FromArgb(-986896);
            ColorToKnownColor[-6250336] = KnownColor.ControlDark;
            KnownColorToColor[KnownColor.ControlDark] = Color.FromArgb(-6250336);
            ColorToKnownColor[-9868951] = KnownColor.ControlDarkDark;
            KnownColorToColor[KnownColor.ControlDarkDark] = Color.FromArgb(-9868951);
            ColorToKnownColor[-1842205] = KnownColor.ControlLight;
            KnownColorToColor[KnownColor.ControlLight] = Color.FromArgb(-1842205);
            ColorToKnownColor[-1] = KnownColor.ControlLightLight;
            KnownColorToColor[KnownColor.ControlLightLight] = Color.FromArgb(-1);
            ColorToKnownColor[-16777216] = KnownColor.ControlText;
            KnownColorToColor[KnownColor.ControlText] = Color.FromArgb(-16777216);
            ColorToKnownColor[-16777216] = KnownColor.Desktop;
            KnownColorToColor[KnownColor.Desktop] = Color.FromArgb(-16777216);
            ColorToKnownColor[-9605779] = KnownColor.GrayText;
            KnownColorToColor[KnownColor.GrayText] = Color.FromArgb(-9605779);
            ColorToKnownColor[-16746281] = KnownColor.Highlight;
            KnownColorToColor[KnownColor.Highlight] = Color.FromArgb(-16746281);
            ColorToKnownColor[-1] = KnownColor.HighlightText;
            KnownColorToColor[KnownColor.HighlightText] = Color.FromArgb(-1);
            ColorToKnownColor[-16750900] = KnownColor.HotTrack;
            KnownColorToColor[KnownColor.HotTrack] = Color.FromArgb(-16750900);
            ColorToKnownColor[-722948] = KnownColor.InactiveBorder;
            KnownColorToColor[KnownColor.InactiveBorder] = Color.FromArgb(-722948);
            ColorToKnownColor[-4207141] = KnownColor.InactiveCaption;
            KnownColorToColor[KnownColor.InactiveCaption] = Color.FromArgb(-4207141);
            ColorToKnownColor[-16777216] = KnownColor.InactiveCaptionText;
            KnownColorToColor[KnownColor.InactiveCaptionText] = Color.FromArgb(-16777216);
            ColorToKnownColor[-31] = KnownColor.Info;
            KnownColorToColor[KnownColor.Info] = Color.FromArgb(-31);
            ColorToKnownColor[-16777216] = KnownColor.InfoText;
            KnownColorToColor[KnownColor.InfoText] = Color.FromArgb(-16777216);
            ColorToKnownColor[-986896] = KnownColor.Menu;
            KnownColorToColor[KnownColor.Menu] = Color.FromArgb(-986896);
            ColorToKnownColor[-16777216] = KnownColor.MenuText;
            KnownColorToColor[KnownColor.MenuText] = Color.FromArgb(-16777216);
            ColorToKnownColor[-3618616] = KnownColor.ScrollBar;
            KnownColorToColor[KnownColor.ScrollBar] = Color.FromArgb(-3618616);
            ColorToKnownColor[-1] = KnownColor.Window;
            KnownColorToColor[KnownColor.Window] = Color.FromArgb(-1);
            ColorToKnownColor[-10197916] = KnownColor.WindowFrame;
            KnownColorToColor[KnownColor.WindowFrame] = Color.FromArgb(-10197916);
            ColorToKnownColor[-16777216] = KnownColor.WindowText;
            KnownColorToColor[KnownColor.WindowText] = Color.FromArgb(-16777216);
            ColorToKnownColor[16777215] = KnownColor.Transparent;
            KnownColorToColor[KnownColor.Transparent] = Color.FromArgb(16777215);
            ColorToKnownColor[-984833] = KnownColor.AliceBlue;
            KnownColorToColor[KnownColor.AliceBlue] = Color.FromArgb(-984833);
            ColorToKnownColor[-332841] = KnownColor.AntiqueWhite;
            KnownColorToColor[KnownColor.AntiqueWhite] = Color.FromArgb(-332841);
            ColorToKnownColor[-16711681] = KnownColor.Aqua;
            KnownColorToColor[KnownColor.Aqua] = Color.FromArgb(-16711681);
            ColorToKnownColor[-8388652] = KnownColor.Aquamarine;
            KnownColorToColor[KnownColor.Aquamarine] = Color.FromArgb(-8388652);
            ColorToKnownColor[-983041] = KnownColor.Azure;
            KnownColorToColor[KnownColor.Azure] = Color.FromArgb(-983041);
            ColorToKnownColor[-657956] = KnownColor.Beige;
            KnownColorToColor[KnownColor.Beige] = Color.FromArgb(-657956);
            ColorToKnownColor[-6972] = KnownColor.Bisque;
            KnownColorToColor[KnownColor.Bisque] = Color.FromArgb(-6972);
            ColorToKnownColor[-16777216] = KnownColor.Black;
            KnownColorToColor[KnownColor.Black] = Color.FromArgb(-16777216);
            ColorToKnownColor[-5171] = KnownColor.BlanchedAlmond;
            KnownColorToColor[KnownColor.BlanchedAlmond] = Color.FromArgb(-5171);
            ColorToKnownColor[-16776961] = KnownColor.Blue;
            KnownColorToColor[KnownColor.Blue] = Color.FromArgb(-16776961);
            ColorToKnownColor[-7722014] = KnownColor.BlueViolet;
            KnownColorToColor[KnownColor.BlueViolet] = Color.FromArgb(-7722014);
            ColorToKnownColor[-5952982] = KnownColor.Brown;
            KnownColorToColor[KnownColor.Brown] = Color.FromArgb(-5952982);
            ColorToKnownColor[-2180985] = KnownColor.BurlyWood;
            KnownColorToColor[KnownColor.BurlyWood] = Color.FromArgb(-2180985);
            ColorToKnownColor[-10510688] = KnownColor.CadetBlue;
            KnownColorToColor[KnownColor.CadetBlue] = Color.FromArgb(-10510688);
            ColorToKnownColor[-8388864] = KnownColor.Chartreuse;
            KnownColorToColor[KnownColor.Chartreuse] = Color.FromArgb(-8388864);
            ColorToKnownColor[-2987746] = KnownColor.Chocolate;
            KnownColorToColor[KnownColor.Chocolate] = Color.FromArgb(-2987746);
            ColorToKnownColor[-32944] = KnownColor.Coral;
            KnownColorToColor[KnownColor.Coral] = Color.FromArgb(-32944);
            ColorToKnownColor[-10185235] = KnownColor.CornflowerBlue;
            KnownColorToColor[KnownColor.CornflowerBlue] = Color.FromArgb(-10185235);
            ColorToKnownColor[-1828] = KnownColor.Cornsilk;
            KnownColorToColor[KnownColor.Cornsilk] = Color.FromArgb(-1828);
            ColorToKnownColor[-2354116] = KnownColor.Crimson;
            KnownColorToColor[KnownColor.Crimson] = Color.FromArgb(-2354116);
            ColorToKnownColor[-16711681] = KnownColor.Cyan;
            KnownColorToColor[KnownColor.Cyan] = Color.FromArgb(-16711681);
            ColorToKnownColor[-16777077] = KnownColor.DarkBlue;
            KnownColorToColor[KnownColor.DarkBlue] = Color.FromArgb(-16777077);
            ColorToKnownColor[-16741493] = KnownColor.DarkCyan;
            KnownColorToColor[KnownColor.DarkCyan] = Color.FromArgb(-16741493);
            ColorToKnownColor[-4684277] = KnownColor.DarkGoldenrod;
            KnownColorToColor[KnownColor.DarkGoldenrod] = Color.FromArgb(-4684277);
            ColorToKnownColor[-5658199] = KnownColor.DarkGray;
            KnownColorToColor[KnownColor.DarkGray] = Color.FromArgb(-5658199);
            ColorToKnownColor[-16751616] = KnownColor.DarkGreen;
            KnownColorToColor[KnownColor.DarkGreen] = Color.FromArgb(-16751616);
            ColorToKnownColor[-4343957] = KnownColor.DarkKhaki;
            KnownColorToColor[KnownColor.DarkKhaki] = Color.FromArgb(-4343957);
            ColorToKnownColor[-7667573] = KnownColor.DarkMagenta;
            KnownColorToColor[KnownColor.DarkMagenta] = Color.FromArgb(-7667573);
            ColorToKnownColor[-11179217] = KnownColor.DarkOliveGreen;
            KnownColorToColor[KnownColor.DarkOliveGreen] = Color.FromArgb(-11179217);
            ColorToKnownColor[-29696] = KnownColor.DarkOrange;
            KnownColorToColor[KnownColor.DarkOrange] = Color.FromArgb(-29696);
            ColorToKnownColor[-6737204] = KnownColor.DarkOrchid;
            KnownColorToColor[KnownColor.DarkOrchid] = Color.FromArgb(-6737204);
            ColorToKnownColor[-7667712] = KnownColor.DarkRed;
            KnownColorToColor[KnownColor.DarkRed] = Color.FromArgb(-7667712);
            ColorToKnownColor[-1468806] = KnownColor.DarkSalmon;
            KnownColorToColor[KnownColor.DarkSalmon] = Color.FromArgb(-1468806);
            ColorToKnownColor[-7357301] = KnownColor.DarkSeaGreen;
            KnownColorToColor[KnownColor.DarkSeaGreen] = Color.FromArgb(-7357301);
            ColorToKnownColor[-12042869] = KnownColor.DarkSlateBlue;
            KnownColorToColor[KnownColor.DarkSlateBlue] = Color.FromArgb(-12042869);
            ColorToKnownColor[-13676721] = KnownColor.DarkSlateGray;
            KnownColorToColor[KnownColor.DarkSlateGray] = Color.FromArgb(-13676721);
            ColorToKnownColor[-16724271] = KnownColor.DarkTurquoise;
            KnownColorToColor[KnownColor.DarkTurquoise] = Color.FromArgb(-16724271);
            ColorToKnownColor[-7077677] = KnownColor.DarkViolet;
            KnownColorToColor[KnownColor.DarkViolet] = Color.FromArgb(-7077677);
            ColorToKnownColor[-60269] = KnownColor.DeepPink;
            KnownColorToColor[KnownColor.DeepPink] = Color.FromArgb(-60269);
            ColorToKnownColor[-16728065] = KnownColor.DeepSkyBlue;
            KnownColorToColor[KnownColor.DeepSkyBlue] = Color.FromArgb(-16728065);
            ColorToKnownColor[-9868951] = KnownColor.DimGray;
            KnownColorToColor[KnownColor.DimGray] = Color.FromArgb(-9868951);
            ColorToKnownColor[-14774017] = KnownColor.DodgerBlue;
            KnownColorToColor[KnownColor.DodgerBlue] = Color.FromArgb(-14774017);
            ColorToKnownColor[-5103070] = KnownColor.Firebrick;
            KnownColorToColor[KnownColor.Firebrick] = Color.FromArgb(-5103070);
            ColorToKnownColor[-1296] = KnownColor.FloralWhite;
            KnownColorToColor[KnownColor.FloralWhite] = Color.FromArgb(-1296);
            ColorToKnownColor[-14513374] = KnownColor.ForestGreen;
            KnownColorToColor[KnownColor.ForestGreen] = Color.FromArgb(-14513374);
            ColorToKnownColor[-65281] = KnownColor.Fuchsia;
            KnownColorToColor[KnownColor.Fuchsia] = Color.FromArgb(-65281);
            ColorToKnownColor[-2302756] = KnownColor.Gainsboro;
            KnownColorToColor[KnownColor.Gainsboro] = Color.FromArgb(-2302756);
            ColorToKnownColor[-460545] = KnownColor.GhostWhite;
            KnownColorToColor[KnownColor.GhostWhite] = Color.FromArgb(-460545);
            ColorToKnownColor[-10496] = KnownColor.Gold;
            KnownColorToColor[KnownColor.Gold] = Color.FromArgb(-10496);
            ColorToKnownColor[-2448096] = KnownColor.Goldenrod;
            KnownColorToColor[KnownColor.Goldenrod] = Color.FromArgb(-2448096);
            ColorToKnownColor[-8355712] = KnownColor.Gray;
            KnownColorToColor[KnownColor.Gray] = Color.FromArgb(-8355712);
            ColorToKnownColor[-16744448] = KnownColor.Green;
            KnownColorToColor[KnownColor.Green] = Color.FromArgb(-16744448);
            ColorToKnownColor[-5374161] = KnownColor.GreenYellow;
            KnownColorToColor[KnownColor.GreenYellow] = Color.FromArgb(-5374161);
            ColorToKnownColor[-983056] = KnownColor.Honeydew;
            KnownColorToColor[KnownColor.Honeydew] = Color.FromArgb(-983056);
            ColorToKnownColor[-38476] = KnownColor.HotPink;
            KnownColorToColor[KnownColor.HotPink] = Color.FromArgb(-38476);
            ColorToKnownColor[-3318692] = KnownColor.IndianRed;
            KnownColorToColor[KnownColor.IndianRed] = Color.FromArgb(-3318692);
            ColorToKnownColor[-11861886] = KnownColor.Indigo;
            KnownColorToColor[KnownColor.Indigo] = Color.FromArgb(-11861886);
            ColorToKnownColor[-16] = KnownColor.Ivory;
            KnownColorToColor[KnownColor.Ivory] = Color.FromArgb(-16);
            ColorToKnownColor[-989556] = KnownColor.Khaki;
            KnownColorToColor[KnownColor.Khaki] = Color.FromArgb(-989556);
            ColorToKnownColor[-1644806] = KnownColor.Lavender;
            KnownColorToColor[KnownColor.Lavender] = Color.FromArgb(-1644806);
            ColorToKnownColor[-3851] = KnownColor.LavenderBlush;
            KnownColorToColor[KnownColor.LavenderBlush] = Color.FromArgb(-3851);
            ColorToKnownColor[-8586240] = KnownColor.LawnGreen;
            KnownColorToColor[KnownColor.LawnGreen] = Color.FromArgb(-8586240);
            ColorToKnownColor[-1331] = KnownColor.LemonChiffon;
            KnownColorToColor[KnownColor.LemonChiffon] = Color.FromArgb(-1331);
            ColorToKnownColor[-5383962] = KnownColor.LightBlue;
            KnownColorToColor[KnownColor.LightBlue] = Color.FromArgb(-5383962);
            ColorToKnownColor[-1015680] = KnownColor.LightCoral;
            KnownColorToColor[KnownColor.LightCoral] = Color.FromArgb(-1015680);
            ColorToKnownColor[-2031617] = KnownColor.LightCyan;
            KnownColorToColor[KnownColor.LightCyan] = Color.FromArgb(-2031617);
            ColorToKnownColor[-329006] = KnownColor.LightGoldenrodYellow;
            KnownColorToColor[KnownColor.LightGoldenrodYellow] = Color.FromArgb(-329006);
            ColorToKnownColor[-2894893] = KnownColor.LightGray;
            KnownColorToColor[KnownColor.LightGray] = Color.FromArgb(-2894893);
            ColorToKnownColor[-7278960] = KnownColor.LightGreen;
            KnownColorToColor[KnownColor.LightGreen] = Color.FromArgb(-7278960);
            ColorToKnownColor[-18751] = KnownColor.LightPink;
            KnownColorToColor[KnownColor.LightPink] = Color.FromArgb(-18751);
            ColorToKnownColor[-24454] = KnownColor.LightSalmon;
            KnownColorToColor[KnownColor.LightSalmon] = Color.FromArgb(-24454);
            ColorToKnownColor[-14634326] = KnownColor.LightSeaGreen;
            KnownColorToColor[KnownColor.LightSeaGreen] = Color.FromArgb(-14634326);
            ColorToKnownColor[-7876870] = KnownColor.LightSkyBlue;
            KnownColorToColor[KnownColor.LightSkyBlue] = Color.FromArgb(-7876870);
            ColorToKnownColor[-8943463] = KnownColor.LightSlateGray;
            KnownColorToColor[KnownColor.LightSlateGray] = Color.FromArgb(-8943463);
            ColorToKnownColor[-5192482] = KnownColor.LightSteelBlue;
            KnownColorToColor[KnownColor.LightSteelBlue] = Color.FromArgb(-5192482);
            ColorToKnownColor[-32] = KnownColor.LightYellow;
            KnownColorToColor[KnownColor.LightYellow] = Color.FromArgb(-32);
            ColorToKnownColor[-16711936] = KnownColor.Lime;
            KnownColorToColor[KnownColor.Lime] = Color.FromArgb(-16711936);
            ColorToKnownColor[-13447886] = KnownColor.LimeGreen;
            KnownColorToColor[KnownColor.LimeGreen] = Color.FromArgb(-13447886);
            ColorToKnownColor[-331546] = KnownColor.Linen;
            KnownColorToColor[KnownColor.Linen] = Color.FromArgb(-331546);
            ColorToKnownColor[-65281] = KnownColor.Magenta;
            KnownColorToColor[KnownColor.Magenta] = Color.FromArgb(-65281);
            ColorToKnownColor[-8388608] = KnownColor.Maroon;
            KnownColorToColor[KnownColor.Maroon] = Color.FromArgb(-8388608);
            ColorToKnownColor[-10039894] = KnownColor.MediumAquamarine;
            KnownColorToColor[KnownColor.MediumAquamarine] = Color.FromArgb(-10039894);
            ColorToKnownColor[-16777011] = KnownColor.MediumBlue;
            KnownColorToColor[KnownColor.MediumBlue] = Color.FromArgb(-16777011);
            ColorToKnownColor[-4565549] = KnownColor.MediumOrchid;
            KnownColorToColor[KnownColor.MediumOrchid] = Color.FromArgb(-4565549);
            ColorToKnownColor[-7114533] = KnownColor.MediumPurple;
            KnownColorToColor[KnownColor.MediumPurple] = Color.FromArgb(-7114533);
            ColorToKnownColor[-12799119] = KnownColor.MediumSeaGreen;
            KnownColorToColor[KnownColor.MediumSeaGreen] = Color.FromArgb(-12799119);
            ColorToKnownColor[-8689426] = KnownColor.MediumSlateBlue;
            KnownColorToColor[KnownColor.MediumSlateBlue] = Color.FromArgb(-8689426);
            ColorToKnownColor[-16713062] = KnownColor.MediumSpringGreen;
            KnownColorToColor[KnownColor.MediumSpringGreen] = Color.FromArgb(-16713062);
            ColorToKnownColor[-12004916] = KnownColor.MediumTurquoise;
            KnownColorToColor[KnownColor.MediumTurquoise] = Color.FromArgb(-12004916);
            ColorToKnownColor[-3730043] = KnownColor.MediumVioletRed;
            KnownColorToColor[KnownColor.MediumVioletRed] = Color.FromArgb(-3730043);
            ColorToKnownColor[-15132304] = KnownColor.MidnightBlue;
            KnownColorToColor[KnownColor.MidnightBlue] = Color.FromArgb(-15132304);
            ColorToKnownColor[-655366] = KnownColor.MintCream;
            KnownColorToColor[KnownColor.MintCream] = Color.FromArgb(-655366);
            ColorToKnownColor[-6943] = KnownColor.MistyRose;
            KnownColorToColor[KnownColor.MistyRose] = Color.FromArgb(-6943);
            ColorToKnownColor[-6987] = KnownColor.Moccasin;
            KnownColorToColor[KnownColor.Moccasin] = Color.FromArgb(-6987);
            ColorToKnownColor[-8531] = KnownColor.NavajoWhite;
            KnownColorToColor[KnownColor.NavajoWhite] = Color.FromArgb(-8531);
            ColorToKnownColor[-16777088] = KnownColor.Navy;
            KnownColorToColor[KnownColor.Navy] = Color.FromArgb(-16777088);
            ColorToKnownColor[-133658] = KnownColor.OldLace;
            KnownColorToColor[KnownColor.OldLace] = Color.FromArgb(-133658);
            ColorToKnownColor[-8355840] = KnownColor.Olive;
            KnownColorToColor[KnownColor.Olive] = Color.FromArgb(-8355840);
            ColorToKnownColor[-9728477] = KnownColor.OliveDrab;
            KnownColorToColor[KnownColor.OliveDrab] = Color.FromArgb(-9728477);
            ColorToKnownColor[-23296] = KnownColor.Orange;
            KnownColorToColor[KnownColor.Orange] = Color.FromArgb(-23296);
            ColorToKnownColor[-47872] = KnownColor.OrangeRed;
            KnownColorToColor[KnownColor.OrangeRed] = Color.FromArgb(-47872);
            ColorToKnownColor[-2461482] = KnownColor.Orchid;
            KnownColorToColor[KnownColor.Orchid] = Color.FromArgb(-2461482);
            ColorToKnownColor[-1120086] = KnownColor.PaleGoldenrod;
            KnownColorToColor[KnownColor.PaleGoldenrod] = Color.FromArgb(-1120086);
            ColorToKnownColor[-6751336] = KnownColor.PaleGreen;
            KnownColorToColor[KnownColor.PaleGreen] = Color.FromArgb(-6751336);
            ColorToKnownColor[-5247250] = KnownColor.PaleTurquoise;
            KnownColorToColor[KnownColor.PaleTurquoise] = Color.FromArgb(-5247250);
            ColorToKnownColor[-2396013] = KnownColor.PaleVioletRed;
            KnownColorToColor[KnownColor.PaleVioletRed] = Color.FromArgb(-2396013);
            ColorToKnownColor[-4139] = KnownColor.PapayaWhip;
            KnownColorToColor[KnownColor.PapayaWhip] = Color.FromArgb(-4139);
            ColorToKnownColor[-9543] = KnownColor.PeachPuff;
            KnownColorToColor[KnownColor.PeachPuff] = Color.FromArgb(-9543);
            ColorToKnownColor[-3308225] = KnownColor.Peru;
            KnownColorToColor[KnownColor.Peru] = Color.FromArgb(-3308225);
            ColorToKnownColor[-16181] = KnownColor.Pink;
            KnownColorToColor[KnownColor.Pink] = Color.FromArgb(-16181);
            ColorToKnownColor[-2252579] = KnownColor.Plum;
            KnownColorToColor[KnownColor.Plum] = Color.FromArgb(-2252579);
            ColorToKnownColor[-5185306] = KnownColor.PowderBlue;
            KnownColorToColor[KnownColor.PowderBlue] = Color.FromArgb(-5185306);
            ColorToKnownColor[-8388480] = KnownColor.Purple;
            KnownColorToColor[KnownColor.Purple] = Color.FromArgb(-8388480);
            ColorToKnownColor[-65536] = KnownColor.Red;
            KnownColorToColor[KnownColor.Red] = Color.FromArgb(-65536);
            ColorToKnownColor[-4419697] = KnownColor.RosyBrown;
            KnownColorToColor[KnownColor.RosyBrown] = Color.FromArgb(-4419697);
            ColorToKnownColor[-12490271] = KnownColor.RoyalBlue;
            KnownColorToColor[KnownColor.RoyalBlue] = Color.FromArgb(-12490271);
            ColorToKnownColor[-7650029] = KnownColor.SaddleBrown;
            KnownColorToColor[KnownColor.SaddleBrown] = Color.FromArgb(-7650029);
            ColorToKnownColor[-360334] = KnownColor.Salmon;
            KnownColorToColor[KnownColor.Salmon] = Color.FromArgb(-360334);
            ColorToKnownColor[-744352] = KnownColor.SandyBrown;
            KnownColorToColor[KnownColor.SandyBrown] = Color.FromArgb(-744352);
            ColorToKnownColor[-13726889] = KnownColor.SeaGreen;
            KnownColorToColor[KnownColor.SeaGreen] = Color.FromArgb(-13726889);
            ColorToKnownColor[-2578] = KnownColor.SeaShell;
            KnownColorToColor[KnownColor.SeaShell] = Color.FromArgb(-2578);
            ColorToKnownColor[-6270419] = KnownColor.Sienna;
            KnownColorToColor[KnownColor.Sienna] = Color.FromArgb(-6270419);
            ColorToKnownColor[-4144960] = KnownColor.Silver;
            KnownColorToColor[KnownColor.Silver] = Color.FromArgb(-4144960);
            ColorToKnownColor[-7876885] = KnownColor.SkyBlue;
            KnownColorToColor[KnownColor.SkyBlue] = Color.FromArgb(-7876885);
            ColorToKnownColor[-9807155] = KnownColor.SlateBlue;
            KnownColorToColor[KnownColor.SlateBlue] = Color.FromArgb(-9807155);
            ColorToKnownColor[-9404272] = KnownColor.SlateGray;
            KnownColorToColor[KnownColor.SlateGray] = Color.FromArgb(-9404272);
            ColorToKnownColor[-1286] = KnownColor.Snow;
            KnownColorToColor[KnownColor.Snow] = Color.FromArgb(-1286);
            ColorToKnownColor[-16711809] = KnownColor.SpringGreen;
            KnownColorToColor[KnownColor.SpringGreen] = Color.FromArgb(-16711809);
            ColorToKnownColor[-12156236] = KnownColor.SteelBlue;
            KnownColorToColor[KnownColor.SteelBlue] = Color.FromArgb(-12156236);
            ColorToKnownColor[-2968436] = KnownColor.Tan;
            KnownColorToColor[KnownColor.Tan] = Color.FromArgb(-2968436);
            ColorToKnownColor[-16744320] = KnownColor.Teal;
            KnownColorToColor[KnownColor.Teal] = Color.FromArgb(-16744320);
            ColorToKnownColor[-2572328] = KnownColor.Thistle;
            KnownColorToColor[KnownColor.Thistle] = Color.FromArgb(-2572328);
            ColorToKnownColor[-40121] = KnownColor.Tomato;
            KnownColorToColor[KnownColor.Tomato] = Color.FromArgb(-40121);
            ColorToKnownColor[-12525360] = KnownColor.Turquoise;
            KnownColorToColor[KnownColor.Turquoise] = Color.FromArgb(-12525360);
            ColorToKnownColor[-1146130] = KnownColor.Violet;
            KnownColorToColor[KnownColor.Violet] = Color.FromArgb(-1146130);
            ColorToKnownColor[-663885] = KnownColor.Wheat;
            KnownColorToColor[KnownColor.Wheat] = Color.FromArgb(-663885);
            ColorToKnownColor[-1] = KnownColor.White;
            KnownColorToColor[KnownColor.White] = Color.FromArgb(-1);
            ColorToKnownColor[-657931] = KnownColor.WhiteSmoke;
            KnownColorToColor[KnownColor.WhiteSmoke] = Color.FromArgb(-657931);
            ColorToKnownColor[-256] = KnownColor.Yellow;
            KnownColorToColor[KnownColor.Yellow] = Color.FromArgb(-256);
            ColorToKnownColor[-6632142] = KnownColor.YellowGreen;
            KnownColorToColor[KnownColor.YellowGreen] = Color.FromArgb(-6632142);
            ColorToKnownColor[-986896] = KnownColor.ButtonFace;
            KnownColorToColor[KnownColor.ButtonFace] = Color.FromArgb(-986896);
            ColorToKnownColor[-1] = KnownColor.ButtonHighlight;
            KnownColorToColor[KnownColor.ButtonHighlight] = Color.FromArgb(-1);
            ColorToKnownColor[-6250336] = KnownColor.ButtonShadow;
            KnownColorToColor[KnownColor.ButtonShadow] = Color.FromArgb(-6250336);
            ColorToKnownColor[-4599318] = KnownColor.GradientActiveCaption;
            KnownColorToColor[KnownColor.GradientActiveCaption] = Color.FromArgb(-4599318);
            ColorToKnownColor[-2628366] = KnownColor.GradientInactiveCaption;
            KnownColorToColor[KnownColor.GradientInactiveCaption] = Color.FromArgb(-2628366);
            ColorToKnownColor[-986896] = KnownColor.MenuBar;
            KnownColorToColor[KnownColor.MenuBar] = Color.FromArgb(-986896);
            ColorToKnownColor[-16746281] = KnownColor.MenuHighlight;
            KnownColorToColor[KnownColor.MenuHighlight] = Color.FromArgb(-16746281);
        }

        public static bool IsKnownColor(Color color)
        {
            return ColorToKnownColor.ContainsKey(color.ToArgb());
        }

        public static KnownColor ToKnownColor(Color color)
        {
            if (ColorToKnownColor.TryGetValue(color.ToArgb(), out KnownColor result))
                return result;
            return KnownColor.Transparent;
        }

        public static Color FromKnownColor(KnownColor knownColor)
        {
            if (KnownColorToColor.TryGetValue(knownColor, out Color result))
                return result;
            return Color.Transparent;
        }

        public static bool IsSystemColor(Color c)
        {
            if (IsKnownColor(c))
            {
                KnownColor knownColor = ToKnownColor(c);
                return ((((KnownColor)knownColor) <= KnownColor.WindowText) || (((KnownColor)knownColor) > KnownColor.YellowGreen));
            }
            return false;
        }
    }
}
#endif

