﻿namespace Budford.Model
{
    public class GraphicsPack
    {
        public string File;
        public string Title ;
        public string Folder ;
        public string Gui ;
        public bool Active  = false;

        // Lookup table between graphics packs and their GUI
        internal static readonly string[][] Lookup =
        {
            new[]{"AdventureTimeEtDBIDK_1440p", "bcdad4c243049546"},
            new[]{"AdventureTimeEtDBIDK_1800p", "bcda55c343049546"},
            new[]{"AdventureTimeEtDBIDK_2160p", "bc5a74f243049546"},
            new[]{"AdventureTimeEtDBIDK_2880p", "bcda57f343049546"},
            new[]{"AdventureTimeEtDBIDK_360p", "f52bc587082a8d98"},
            new[]{"AdventureTimeEtDBIDK_540p", "f5ab0587082a8d98"},
            new[]{"AdventureTimeF&JI_1080p", "d3de5bf3814f0a1c"},
            new[]{"AdventureTimeF&JI_1440p", "d3ded8f3814f0a1c"},
            new[]{"AdventureTimeF&JI_1800p", "d3de59f2814f0a1c"},
            new[]{"AdventureTimeF&JI_2160p", "d35e78c3814f0a1c"},
            new[]{"AdventureTimeF&JI_360p", "fd33a7039f143846"},
            new[]{"AdventureTimeF&JI_540p", "fdb367039f143846"},
            new[]{"AdventureTimeFinnAndJakeInvestigations_2880p", "6de036db536718c7"},
            new[]{"AdventureTimeFinnAndJakeInvestigations_4320p", "6d6054ba536718c7"},
            new[]{"AdventureTimeFinnAndJakeInvestigations_5760p", "6d60d5aa536718c7"},
            new[]{"Aqua TV_1080p", "4d9903a3c872eb0e"},
            new[]{"Aqua TV_1440p", "4d9980a3c872eb0e"},
            new[]{"Aqua TV_1800p", "4d9901a2c872eb0e"},
            new[]{"Aqua TV_2160p", "4d192093c872eb0e"},
            new[]{"Aqua TV_2880p", "4d990392c872eb0e"},
            new[]{"Aqua TV_360p", "72830791e5d61d7a"},
            new[]{"Aqua TV_4320p", "4d1961f3c872eb0e"},
            new[]{"Aqua TV_540p", "7203c791e5d61d7a"},
            new[]{"Aqua TV_5760p", "4d19e0e3c872eb0e"},
            new[]{"BatmanArkhamCityArmoredEdition_2880p", "7c414b395db07fcf"},
            new[]{"BatmanArkhamCityArmoredEdition_4320p", "7cc129585db07fcf"},
            new[]{"BatmanArkhamCityArmoredEdition_5760p", "7cc1a8485db07fcf"},
            new[]{"BatmanArkham_1080p", "5865f76821bd3f41"},
            new[]{"BatmanArkham_1440p", "5865746821bd3f41"},
            new[]{"BatmanArkham_1800p", "5865f56921bd3f41"},
            new[]{"BatmanArkham_2160p", "58e5d45821bd3f41"},
            new[]{"BatmanArkham_360p", "8a6a90427a7f8250"},
            new[]{"BatmanArkham_540p", "8aea50427a7f8250"},
            new[]{"Bayonetta2_1080p", "5f0146510b6db472"},
            new[]{"Bayonetta2_1440p", "5f01c5510b6db472"},
            new[]{"Bayonetta2_1800p", "5f0144500b6db472"},
            new[]{"Bayonetta2_2160p", "5f8165610b6db472"},
            new[]{"Bayonetta2_2880p", "5f0146600b6db472"},
            new[]{"Bayonetta2_360p", "4208e316da68e55e"},
            new[]{"Bayonetta2_4320p", "5f8124010b6db472"},
            new[]{"Bayonetta2_540p", "42882316da68e55e"},
            new[]{"Bayonetta2_5760p", "5f81a5110b6db472"},
            new[]{"Bayonetta_Bloom", "df6715cdb16be55e"},
            new[]{"Ben10Omniverse_1080p", "bc4f842841ab4dfd"},
            new[]{"Ben10Omniverse_1440p", "bc4f072841ab4dfd"},
            new[]{"Ben10Omniverse_1800p", "bc4f862941ab4dfd"},
            new[]{"Ben10Omniverse_2160p", "bccfa71841ab4dfd"},
            new[]{"Ben10Omniverse_2880p", "bc4f841941ab4dfd"},
            new[]{"Ben10Omniverse_360p", "df8c1082569bfa99"},
            new[]{"Ben10Omniverse_4320p", "bccfe67841ab4dfd"},
            new[]{"Ben10Omniverse_540p", "df0cd082569bfa99"},
            new[]{"Ben10Omniverse_5760p", "bccf676841ab4dfd"},
            new[]{ "BotW FPS Mod", "660B7153d79e1dec" },
            new[]{"BreathOfTheWild_1080p", "ee3cf612ec4183d4"},
            new[]{"BreathOfTheWild_1080pUW", "d78f3b8fbd047bd0"},
            new[]{"BreathOfTheWild_1440p", "ee3c7512ec4183d4"},
            new[]{"BreathOfTheWild_1440pUW", "d78f3b4f9d047bd0"},
            new[]{"BreathOfTheWild_1800p", "ee3cf413ec4183d4"},
            new[]{"BreathOfTheWild_2160p", "eebcd522ec4183d4"},
            new[]{"BreathOfTheWild_2160pUW", "d78f3b6fb5087bd0"},
            new[]{"BreathOfTheWild_2880p", "ee3cf623ec4183d4"},
            new[]{"BreathOfTheWild_360p", "396864d88306a93d"},
            new[]{"BreathOfTheWild_4320p", "eebc9442ec4183d4"},
            new[]{"BreathOfTheWild_540p", "39e8a4d88306a93d"},
            new[]{"BreathOfTheWild_5760p", "eebc1552ec4183d4"},
            new[]{"BreathOfTheWild_AARemoval", "f284b53067498c91"},
            new[]{"BreathOfTheWild_AdjustableBloom", "a26c3c3568c91541"},
            new[]{"BreathOfTheWild_Contrasty", "67ce74c1ee399093"},
            new[]{"BreathOfTheWild_HighResShadows", "85137bd8b26fa60f"},
            new[]{"BreathOfTheWild_LwzxNullCheck", "7377d3d427303ff0"},
            new[]{"BreathOfTheWild_NoMMTriforce", "e3632fee4862d4a4"},
            new[]{"BreathOfTheWild_ProPlus", "d38f3cf7a8027ad0"},
            new[]{"BrunswickProBowling_2880p", "563b8e4aee2c0d9b"},
            new[]{"BrunswickProBowling_4320p", "56bbec2bee2c0d9b"},
            new[]{"BrunswickProBowling_5760p", "56bb6d3bee2c0d9b"},
            new[]{"Brunswick_1080p", "0baf406eb443cb43"},
            new[]{"Brunswick_1440p", "0bafc36eb443cb43"},
            new[]{"Brunswick_1800p", "0baf426fb443cb43"},
            new[]{"Brunswick_2160p", "0b2f635eb443cb43"},
            new[]{"Brunswick_360p", "1e059d68879687f6"},
            new[]{"Brunswick_540p", "1e855d68879687f6"},
            new[]{"CaptainToad_AARemoval", "43a6b4483d1a0c96"},
            new[]{"CaptainToad_Bloom", "d4e66651f96a9154"},
            new[]{"ChimpuzzlePro_1440p", "968d82b380537d4a"},
            new[]{"ChimpuzzlePro_1800p", "968d03b280537d4a"},
            new[]{"ChimpuzzlePro_2160p", "960d228380537d4a"},
            new[]{"ChimpuzzlePro_2880p", "968d018280537d4a"},
            new[]{"ChimpuzzlePro_360p", "5b872701a7fa94cc"},
            new[]{"ChimpuzzlePro_540p", "5b07e701a7fa94cc"},
            new[]{"ChompyChompChompParty_1080p", "95991413b5bfa3d0"},
            new[]{"ChompyChompChompParty_1440p", "95999713b5bfa3d0"},
            new[]{"ChompyChompChompParty_1800p", "95991612b5bfa3d0"},
            new[]{"ChompyChompChompParty_2160p", "95193723b5bfa3d0"},
            new[]{"ChompyChompChompParty_2880p", "95991422b5bfa3d0"},
            new[]{"ChompyChompChompParty_360p", "73ad676a7f47a1cb"},
            new[]{"ChompyChompChompParty_540p", "732da76a7f47a1cb"},
            new[]{"CitizensOfEarth_1080p", "81ef47bbe86bbd8b"},
            new[]{"CitizensOfEarth_1440p", "81efc4bbe86bbd8b"},
            new[]{"CitizensOfEarth_1800p", "81ef45bae86bbd8b"},
            new[]{"CitizensOfEarth_2160p", "816f648be86bbd8b"},
            new[]{"CitizensOfEarth_360p", "9f0b37d1d77a17e3"},
            new[]{"CitizensOfEarth_540p", "9f8bf7d1d77a17e3"},
            new[]{"ColorSplash_1080p", "c54ec0b38c46b55a"},
            new[]{"ColorSplash_1080pUW", "5a6cb113f02ca351"},
            new[]{"ColorSplash_1440p", "c54e43b38c46b55a"},
            new[]{"ColorSplash_1800p", "c54ec2b28c46b55a"},
            new[]{"ColorSplash_2160p", "c5cee3838c46b55a"},
            new[]{"ColorSplash_2880p", "c54ec0828c46b55a"},
            new[]{"ColorSplash_360p", "dd0426198d6ab56a"},
            new[]{"ColorSplash_4320p", "c5cea2e38c46b55a"},
            new[]{"ColorSplash_540p", "dd84e6198d6ab56a"},
            new[]{"ColorSplash_5760p", "c5ce23f38c46b55a"},
            new[]{"ColorSplash_AARemoval", "84e45688452e9f9b"},
            new[]{"ColorSplash_ColorlessSpots", "d04a01f2db6c91c1"},
            new[]{"DuckTalesRemastered_1440p", "53c91633bc220343"},
            new[]{"DuckTalesRemastered_1800p", "53c99732bc220343"},
            new[]{"DuckTalesRemastered_2160p", "5349b603bc220343"},
            new[]{"DuckTalesRemastered_2880p", "53c99502bc220343"},
            new[]{"DuckTalesRemastered_360p", "d2af267845068646"},
            new[]{"DuckTalesRemastered_540p", "d22fe67845068646"},
            new[]{"DuckTalesRemastered_720p", "d2afa77845068646"},
            new[]{"ElectronicSuperJoyGrooveCity_1440p", "63481796a66039e4"},
            new[]{"ElectronicSuperJoyGrooveCity_1800p", "63489697a66039e4"},
            new[]{"ElectronicSuperJoyGrooveCity_2160p", "63c8b7a6a66039e4"},
            new[]{"ElectronicSuperJoyGrooveCity_2880p", "634894a7a66039e4"},
            new[]{"FamilyTennisSP_1080p", "3ba934e0194795fd"},
            new[]{"FamilyTennisSP_1440p", "3ba9b7e0194795fd"},
            new[]{"FamilyTennisSP_1800p", "3ba936e1194795fd"},
            new[]{"FamilyTennisSP_2160p", "3b2917d0194795fd"},
            new[]{"FamilyTennisSP_2880p", "3ba934d1194795fd"},
            new[]{"FamilyTennisSP_360p", "12ed81338e2afb97"},
            new[]{"FamilyTennisSP_4320p", "3b2956b0194795fd"},
            new[]{"FamilyTennisSP_540p", "126d41338e2afb97"},
            new[]{"FamilyTennisSP_5760p", "3b29d7a0194795fd"},
            new[]{"FASTRacingNEO_1080p", "16ed93128861c910"},
            new[]{"FASTRacingNEO_1440p", "16ed10128861c910"},
            new[]{"FASTRacingNEO_1800p", "16ed91138861c910"},
            new[]{"FASTRacingNEO_2160p", "166db0228861c910"},
            new[]{"FASTRacingNEO_360p", "9aa36410c39221cc"},
            new[]{"FASTRacingNEO_540p", "9a23a410c39221cc"},
            new[]{"FistoftheNorthStarKen'sRage2_1080p", "c6e468aa4758970c"},
            new[]{"FistoftheNorthStarKen'sRage2_1440p", "c6e4ebaa4758970c"},
            new[]{"FistoftheNorthStarKen'sRage2_1800p", "c6e46aab4758970c"},
            new[]{"FistoftheNorthStarKen'sRage2_2160p", "c6644b9a4758970c"},
            new[]{"FistoftheNorthStarKen'sRage2_2880p", "c6e4689b4758970c"},
            new[]{"FistoftheNorthStarKen'sRage2_360p", "8955158fb02e196c"},
            new[]{"FistoftheNorthStarKen'sRage2_4320p", "c6640afa4758970c"},
            new[]{"FistoftheNorthStarKen'sRage2_540p", "89d5d58fb02e196c"},
            new[]{"FistoftheNorthStarKen'sRage2_5760p", "c6648bea4758970c"},
            new[]{"FrenchyBird_1440p", "822c50baa84cb252"},
            new[]{"FrenchyBird_1800p", "822cd1bba84cb252"},
            new[]{"FrenchyBird_2160p", "82acf08aa84cb252"},
            new[]{"FrenchyBird_2880p", "822cd38ba84cb252"},
            new[]{"FrenchyBird_360p", "192234519964a5e4"},
            new[]{"FrenchyBird_540p", "19a2f4519964a5e4"},
            new[]{"GhostBladeHD_1080p", "9fc136c059afa4ce"},
            new[]{"GhostBladeHD_1440p", "9fc1b5c059afa4ce"},
            new[]{"GhostBladeHD_1800p", "9fc134c159afa4ce"},
            new[]{"GhostBladeHD_2160p", "9f4115f059afa4ce"},
            new[]{"GhostBladeHD_360p", "c3e9c1b35e499ddf"},
            new[]{"GhostBladeHD_540p", "c36901b35e499ddf"},
            new[]{"Guacamelee!SuperTurboChampionshipEdition_2880p", "9b8269015a6ca524"},
            new[]{"Guacamelee_1080p", "57e387915b3bbdea"},
            new[]{"Guacamelee_1440p", "57e304915b3bbdea"},
            new[]{"Guacamelee_1800p", "57e385905b3bbdea"},
            new[]{"Guacamelee_2160p", "5763a4a15b3bbdea"},
            new[]{"Guacamelee_360p", "868b62b7767ad54f"},
            new[]{"Guacamelee_540p", "860ba2b7767ad54f"},
            new[]{"HighResGamepad", "0aecfe13d486b364"},
            new[]{"InfinityRunner_1080p", "1b2ef7e1594b39a5"},
            new[]{"InfinityRunner_1440p", "1b2e74e1594b39a5"},
            new[]{"InfinityRunner_1800p", "1b2ef5e0594b39a5"},
            new[]{"InfinityRunner_2160p", "1baed4d1594b39a5"},
            new[]{"InfinityRunner_2880p", "1b2ef7d0594b39a5"},
            new[]{"InfinityRunner_360p", "1c6a82b396724ad7"},
            new[]{"InfinityRunner_540p", "1cea42b396724ad7"},
            new[]{"KamenRider-BattrideWarII_2880p", "fb57b7e3b73c87dd"},
            new[]{"KamenRider-BattrideWarII_4320p", "fbd7d582b73c87dd"},
            new[]{"KamenRider-BattrideWarII_5760p", "fbd75492b73c87dd"},
            new[]{"KamenRider_1080p", "9104e6f10b7fbde2"},
            new[]{"KamenRider_1440p", "910465f10b7fbde2"},
            new[]{"KamenRider_1800p", "9104e4f00b7fbde2"},
            new[]{"KamenRider_2160p", "9184c5c10b7fbde2"},
            new[]{"KamenRider_360p", "4948a217fe7ac5c3"},
            new[]{"KamenRider_540p", "49c86217fe7ac5c3"},
            new[]{"KickandFennick_1440p", "9ac886604531b760"},
            new[]{"KickandFennick_1800p", "9ac807614531b760"},
            new[]{"KickandFennick_2160p", "9a4826504531b760"},
            new[]{"KickandFennick_2880p", "9ac805514531b760"},
            new[]{"KickandFennick_360p", "d18f818a626ec1d4"},
            new[]{"KickandFennick_540p", "d10f418a626ec1d4"},
            new[]{"KirbyRainbowCurse_1080p", "bfdf506bad492c0b"},
            new[]{"KirbyRainbowCurse_1440p", "bfdfd36bad492c0b"},
            new[]{"KirbyRainbowCurse_1800p", "bfdf526aad492c0b"},
            new[]{"KirbyRainbowCurse_2160p", "bf5f735bad492c0b"},
            new[]{"KirbyRainbowCurse_2160p_gamepadonly", "4dfd00b63b741e77"},
            new[]{"KirbyRainbowCurse_2880p", "bfdf505aad492c0b"},
            new[]{"KirbyRainbowCurse_2880p_gamepadonly", "4dfd00b603661e77"},
            new[]{"KirbyRainbowCurse_360p", "ff25975a9358169e"},
            new[]{"KirbyRainbowCurse_4320p", "bf5f323bad492c0b"},
            new[]{"KirbyRainbowCurse_5760p", "bf5fb32bad492c0b"},
            new[]{"KungFuPandaShowdownofLegendaryLegends_1080p", "a2a1febb3a87a3ae"},
            new[]{"KungFuPandaShowdownofLegendaryLegends_1440p", "a2a17dbb3a87a3ae"},
            new[]{"KungFuPandaShowdownofLegendaryLegends_1800p", "a2a1fcba3a87a3ae"},
            new[]{"KungFuPandaShowdownofLegendaryLegends_2160p", "a221dd8b3a87a3ae"},
            new[]{"KungFuPandaShowdownofLegendaryLegends_2880p", "a2a1fe8a3a87a3ae"},
            new[]{"KungFuPandaShowdownofLegendaryLegends_360p", "037936750e475da5"},
            new[]{"KungFuPandaShowdownofLegendaryLegends_4320p", "a2219ceb3a87a3ae"},
            new[]{"KungFuPandaShowdownofLegendaryLegends_540p", "03f9f6750e475da5"},
            new[]{"KungFuPandaShowdownofLegendaryLegends_5760p", "a2211dfb3a87a3ae"},
            new[]{"LEGOCityUndercover_1440p", "3d0964d0fb57b4d9"},
            new[]{"LEGOCityUndercover_1800p", "3d09e5d1fb57b4d9"},
            new[]{"LEGOCityUndercover_2160p", "3d89c4e0fb57b4d9"},
            new[]{"LEGOCityUndercover_2880p", "3d09e7e1fb57b4d9"},
            new[]{"LEGOCityUndercover_360p", "524ae0f7af68b39b"},
            new[]{"LEGOCityUndercover_540p", "52ca20f7af68b39b"},
            new[]{"LostWorld_1080p", "07ee23868c7fd558"},
            new[]{"LostWorld_1440p", "07eea0868c7fd558"},
            new[]{"LostWorld_1800p", "07ee21878c7fd558"},
            new[]{"LostWorld_2160p", "076e00b68c7fd558"},
            new[]{"LostWorld_2880p", "07ee23b78c7fd558"},
            new[]{"LostWorld_360p", "9cc34d19ffaab1ee"},
            new[]{"LostWorld_4320p", "076e41d68c7fd558"},
            new[]{"LostWorld_540p", "9c438d19ffaab1ee"},
            new[]{"LostWorld_5760p", "076ec0c68c7fd558"},
            new[]{"LostWorld_Brightness", "be85728bfd2cbcf3"},
            new[]{"MarioTennis_2160p", "842b33b2f4368f55"},
            new[]{"MarioTennis_AARemoval", "8343a59811208218"},
            new[]{"MK8_1080p", "4b9b24f62126ed5c"},
            new[]{"MK8_1080pUW", "ccedd226897d8849"},
            new[]{"MK8_1440p", "4b9ba7f62126ed5c"},
            new[]{"MK8_1800p", "4b9b26f72126ed5c"},
            new[]{"MK8_2160p", "4b1b07c62126ed5c"},
            new[]{"MK8_2160pUW", "ccedd2c681718849"},
            new[]{"MK8_2880p", "4b9b24c72126ed5c"},
            new[]{"MK8_360p", "76cdad434cdab976"},
            new[]{"MK8_4320p", "4b1b46a62126ed5c"},
            new[]{"MK8_540p", "764d6d434cdab976"},
            new[]{"MK8_5760p", "4b1bc7b62126ed5c"},
            new[]{"MK8_AARemoval", "8e6233681d63c14f"},
            new[]{"MK8_AdjustableBloom", "c0859501113a8c5a"},
            new[]{"MK8_HighResShadows", "5740122a545c91cb"},
            new[]{"MN9_1080p", "4b9b24f62122e75c"},
            new[]{"MN9_1440p", "4b9ba7f62122e75c"},
            new[]{"MN9_1800p", "4b9b26f72122e75c"},
            new[]{"MN9_2160p", "4b1b07c62122e75c"},
            new[]{"MN9_360p", "76cdad4344ceb976"},
            new[]{"MN9_540p", "764d6d4344ceb976"},
            new[]{"NBA2K13_1080p", "64fcf1a3c86660c5"},
            new[]{"NBA2K13_1440p", "64fc72a3c86660c5"},
            new[]{"NBA2K13_1800p", "64fcf3a2c86660c5"},
            new[]{"NBA2K13_2160p", "647cd293c86660c5"},
            new[]{"NBA2K13_2880p", "64fcf192c86660c5"},
            new[]{"NBA2K13_360p", "b8670691cdc08a29"},
            new[]{"NBA2K13_540p", "b8e7c691cdc08a29"},
            new[]{"NintendoLand_1080p", "1bc2f74845ad29ce"},
            new[]{"NintendoLand_1440p", "1bc2744845ad29ce"},
            new[]{"NintendoLand_1800p", "1bc2f54945ad29ce"},
            new[]{"NintendoLand_2160p", "1b42d47845ad29ce"},
            new[]{"NintendoLand_2880p", "1bc2f77945ad29ce"},
            new[]{"NintendoLand_360p", "c46bd08a5a539cd7"},
            new[]{"NintendoLand_4320p", "1b42951845ad29ce"},
            new[]{"NintendoLand_540p", "c4eb108a5a539cd7"},
            new[]{"NintendoLand_5760p", "1b42140845ad29ce"},
            new[]{"NintendoLand_HighResShadows", "ffec7b75e619f382"},
            new[]{"NSMBU_1080p", "87cfc0b6f16ef31c"},
            new[]{"NSMBU_1440p", "87cf43b6f16ef31c"},
            new[]{"NSMBU_1800p", "87cfc2b7f16ef31c"},
            new[]{"NSMBU_2160p", "874fe386f16ef31c"},
            new[]{"NSMBU_360p", "df052ce3dde639ee"},
            new[]{"NSMBU_540p", "df85ece3dde639ee"},
            new[]{"NSMBU_AARemoval", "038632ac5126cf4b"},
            new[]{"NSMBU_HighResShadows", "316a600a3c789eeb"},
            new[]{"ONEPIECEUnlimitedWorldRed_2880p", "3417fda3af10cd77"},
            new[]{"ONEPIECEUnlimitedWorldRed_4320p", "34979fc2af10cd77"},
            new[]{"ONEPIECEUnlimitedWorldRed_5760p", "34971ed2af10cd77"},
            new[]{"OnePiece_1080p", "93823ce1218f93e4"},
            new[]{"OnePiece_1440p", "9382bfe1218f93e4"},
            new[]{"OnePiece_1800p", "93823ee0218f93e4"},
            new[]{"OnePiece_2160p", "93021fd1218f93e4"},
            new[]{"OnePiece_360p", "45fd83431e27c9c7"},
            new[]{"OnePiece_540p", "457d43431e27c9c7"},
            new[]{"Pac-ManandtheGhostlyAdventures2_2880p", "ca868c6bacfdb7db"},
            new[]{"Pac-ManandtheGhostlyAdventures2_4320p", "ca06ee0aacfdb7db"},
            new[]{"Pac-ManandtheGhostlyAdventures2_5760p", "ca066f1aacfdb7db"},
            new[]{"Pac-ManandtheGhostlyAdventures_2880p", "4d1d9789956cb775"},
            new[]{"Pac-ManandtheGhostlyAdventures_4320p", "4d9df5e8956cb775"},
            new[]{"Pac-ManandtheGhostlyAdventures_5760p", "4d9d74f8956cb775"},
            new[]{"PacMan_1080p", "79276671abbf9f76"},
            new[]{"PacMan_1440p", "7927e571abbf9f76"},
            new[]{"PacMan_1800p", "79276470abbf9f76"},
            new[]{"PacMan_2160p", "79a74541abbf9f76"},
            new[]{"PacMan_360p", "0e48a3567f3fed12"},
            new[]{"PacMan_540p", "0ec863567f3fed12"},
            new[]{"PaperMonstersRecut_1440p", "598facc9ab4303c1"},
            new[]{"PaperMonstersRecut_1800p", "598f2dc8ab4303c1"},
            new[]{"PaperMonstersRecut_2160p", "590f0cf9ab4303c1"},
            new[]{"PaperMonstersRecut_2880p", "598f2ff8ab4303c1"},
            new[]{"PaperMonstersRecut_360p", "5edbd35787068253"},
            new[]{"PaperMonstersRecut_540p", "5e5b135787068253"},
            new[]{"PhineasFerb_1080p", "000eb2ba9860a45e"},
            new[]{"PhineasFerb_1440p", "000e31ba9860a45e"},
            new[]{"PhineasFerb_1800p", "000eb0bb9860a45e"},
            new[]{"PhineasFerb_2160p", "008e918a9860a45e"},
            new[]{"PhineasFerb_360p", "5ce03431c148bde0"},
            new[]{"PhineasFerb_540p", "5c60f431c148bde0"},
            new[]{"Pikmin3_1080p", "cb9e10a2c866de47"},
            new[]{"Pikmin3_1440p", "cb9e93a2c866de47"},
            new[]{"Pikmin3_1800p", "cb9e12a3c866de47"},
            new[]{"Pikmin3_2160p", "cb1e3392c866de47"},
            new[]{"Pikmin3_2880p", "cb9e1093c866de47"},
            new[]{"Pikmin3_360p", "7da50591cdbc8f76"},
            new[]{"Pikmin3_4320p", "cb1e72f2c866de47"},
            new[]{"Pikmin3_540p", "7d25c591cdbc8f76"},
            new[]{"Pikmin3_5760p", "cb1ef3e2c866de47"},
            new[]{"Pokken_1080p", "fd246671abbf9770"},
            new[]{"Pokken_1440p", "fd24e571abbf9770"},
            new[]{"Pokken_1800p", "fd246470abbf9770"},
            new[]{"Pokken_2160p", "fda44541abbf9770"},
            new[]{"Pokken_360p", "0948a3567f2fe11a"},
            new[]{"Pokken_540p", "09c863567f2fe11a"},
            new[]{"ProjectZero_1080p", "ce4fb29a8060a45e"},
            new[]{"ProjectZero_2160p", "cecf91aa8060a45e"},
            new[]{"ProjectZero_2880p", "ce4fb2ab8060a45e"},
            new[]{"Rio_1080p", "4b9b24f6217ae843"},
            new[]{"Rio_1440p", "4b9ba7f6217ae843"},
            new[]{"Rio_1800p", "4b9b26f7217ae843"},
            new[]{"Rio_2160p", "4b1b07c6217ae843"},
            new[]{"Rio_360p", "76cdad43f4d08776"},
            new[]{"Rio_540p", "764d6d43f4d08776"},
            new[]{"RiseOfLyric_1080p", "cfe912e2f06690c9"},
            new[]{"RiseOfLyric_1440p", "cfe991e2f06690c9"},
            new[]{"RiseOfLyric_1800p", "cfe910e3f06690c9"},
            new[]{"RiseOfLyric_2160p", "cf6931d2f06690c9"},
            new[]{"RiseOfLyric_360p", "93a185e1cd20937f"},
            new[]{"RiseOfLyric_540p", "932145e1cd20937f"},
            new[]{"SanatoryHallways_1440p", "b540878a057f9d4c"},
            new[]{"SanatoryHallways_1800p", "b540068b057f9d4c"},
            new[]{"SanatoryHallways_2160p", "b5c027ba057f9d4c"},
            new[]{"SanatoryHallways_2880p", "b54004bb057f9d4c"},
            new[]{"SanatoryHallways_360p", "c18c550bfe3a998a"},
            new[]{"SanatoryHallways_540p", "c10c950bfe3a998a"},
            new[]{"Scribblenauts_1080p", "106d620ac82bea4a"},
            new[]{"Scribblenauts_1440p", "106de10ac82bea4a"},
            new[]{"Scribblenauts_1800p", "106d600bc82bea4a"},
            new[]{"Scribblenauts_2160p", "10ed413ac82bea4a"},
            new[]{"Scribblenauts_360p", "9a40559057d495c0"},
            new[]{"Scribblenauts_540p", "9ac0959057d495c0"},
            new[]{"Severed_1080p", "8f1921a2c83ac95c"},
            new[]{"Severed_1440p", "8f19a2a2c83ac95c"},
            new[]{"Severed_1800p", "8f1923a3c83ac95c"},
            new[]{"Severed_2160p", "8f990292c83ac95c"},
            new[]{"Severed_360p", "73c605917592b9fe"},
            new[]{"Severed_540p", "7346c5917592b9fe"},
            new[]{"ShovelKnight_1440p", "592255484defa446"},
            new[]{"ShovelKnight_1800p", "5922d4494defa446"},
            new[]{"ShovelKnight_2160p", "59a2f5784defa446"},
            new[]{"ShovelKnight_360p", "0428d09ade498d52"},
            new[]{"ShovelKnight_540p", "04a8109ade498d52"},
            new[]{"ShovelKnight_720p", "0428519ade498d52"},
            new[]{"Smash_1080pUW", "c33e3232b06dbc46"},
            new[]{"Smash_1440p", "c8c843b6f11ad110"},
            new[]{"Smash_1800p", "c8c8c2b7f11ad110"},
            new[]{"Smash_2160p", "c848e386f11ad110"},
            new[]{"Smash_2880p", "c8c8c087f11ad110"},
            new[]{"Smash_360p", "d1052ce335a22170"},
            new[]{"Smash_4320p", "c848a2e6f11ad110"},
            new[]{"Smash_540p", "d185ece335a22170"},
            new[]{"Smash_5760p", "c84823f6f11ad110"},
            new[]{"Smash_720p", "d105ade335a22170"},
            new[]{"Smash_HighResShadows", "9669600a3c428f6d"},
            new[]{"Smash_NoBoxingRingScreen", "c0234238a42cb4cb"},
            new[]{"Sochi_1080p", "c9c8c0b6f11ee712"},
            new[]{"Sochi_1440p", "c9c843b6f11ee712"},
            new[]{"Sochi_1800p", "c9c8c2b7f11ee712"},
            new[]{"Sochi_2160p", "c948e386f11ee712"},
            new[]{"Sochi_360p", "d1052ce33dce2572"},
            new[]{"Sochi_540p", "d185ece33dce2572"},
            new[]{"Splatoon_1080p", "dda6dd0021a38b6e"},
            new[]{"Splatoon_1080pUW", "5561b7693740c8e8"},
            new[]{"Splatoon_1440p", "dda65e0021a38b6e"},
            new[]{"Splatoon_1800p", "dda6df0121a38b6e"},
            new[]{"Splatoon_2160p", "dd26fe3021a38b6e"},
            new[]{"Splatoon_2880p", "dda6dd3121a38b6e"},
            new[]{"Splatoon_360p", "0d3f40424617dd5a"},
            new[]{"Splatoon_4320p", "dd26bf5021a38b6e"},
            new[]{"Splatoon_540p", "0dbf80424617dd5a"},
            new[]{"Splatoon_5760p", "dd263e4021a38b6e"},
            new[]{"Splatoon_AdjustableBloom", "4ce0dabf2c7a2dc3"},
            new[]{"Splatoon_HighResShadows", "9cde6e51d41ea2d2"},
            new[]{"SpongeBob_1080p", "02aae07ff067d348"},
            new[]{"SpongeBob_1440p", "02aa637ff067d348"},
            new[]{"SpongeBob_1800p", "02aae27ef067d348"},
            new[]{"SpongeBob_2160p", "022ac34ff067d348"},
            new[]{"SpongeBob_360p", "1445bee0cfa691e4"},
            new[]{"SpongeBob_540p", "14c57ee0cfa691e4"},
            new[]{"StarFoxGuard_1080p", "1740e4505db38c40"},
            new[]{"StarFoxGuard_1440p", "174067505db38c40"},
            new[]{"StarFoxGuard_1800p", "1740e6515db38c40"},
            new[]{"StarFoxGuard_2160p", "17c0c7605db38c40"},
            new[]{"StarFoxGuard_2880p", "1740e4615db38c40"},
            new[]{"StarFoxGuard_4320p", "17c086005db38c40"},
            new[]{"StarFoxGuard_5760p", "17c007105db38c40"},
            new[]{"StarFoxZero_1080p", "cecc835ab86ca75e"},
            new[]{"StarFoxZero_1440p", "cecc005ab86ca75e"},
            new[]{"StarFoxZero_1800p", "cecc815bb86ca75e"},
            new[]{"StarFoxZero_2160p", "ce4ca06ab86ca75e"},
            new[]{"StarFoxZero_2880p", "cecc836bb86ca75e"},
            new[]{"StarFoxZero_4320p", "ce4ce10ab86ca75e"},
            new[]{"StarFoxZero_5760p", "ce4c601ab86ca75e"},
            new[]{"StarFox_360p", "38c2059195ba9169"},
            new[]{"StarFox_540p", "3842c59195ba9169"},
            new[]{"SuperMario3DWorld_1080p", "509a7266b17b92c4"},
            new[]{"SuperMario3DWorld_1080pUW", "d30b94a69c59ec9e"},
            new[]{"SuperMario3DWorld_1440p", "509af166b17b92c4"},
            new[]{"SuperMario3DWorld_1800p", "509a7067b17b92c4"},
            new[]{"SuperMario3DWorld_2160p", "501a5156b17b92c4"},
            new[]{"SuperMario3DWorld_2880p", "509a7257b17b92c4"},
            new[]{"SuperMario3DWorld_360p", "74618d62f7248941"},
            new[]{"SuperMario3DWorld_4320p", "501a1036b17b92c4"},
            new[]{"SuperMario3DWorld_540p", "74e14d62f7248941"},
            new[]{"SuperMario3DWorld_5760p", "501a9126b17b92c4"},
            new[]{"SuperMario3DWorld_AARemoval", "5797b4d10c03c446"},
            new[]{"SuperMario3DWorld_Bloom", "cd75e75db47b92c4"},
            new[]{"SuperMario3DWorld_HighResShadows", "da4039629cf2ae07"},
            new[]{"Tekken_1080p", "7da66671abbf9770"},
            new[]{"Tekken_1440p", "7da6e571abbf9770"},
            new[]{"Tekken_1800p", "7da66470abbf9770"},
            new[]{"Tekken_2160p", "7d264541abbf9770"},
            new[]{"Tekken_360p", "0c49a3567f2fe11a"},
            new[]{"Tekken_540p", "0cc963567f2fe11a"},
            new[]{"Tengami_1080p", "8e1f51a2c80ed94f"},
            new[]{"Tengami_1440p", "8e1fd2a2c80ed94f"},
            new[]{"Tengami_1800p", "8e1f53a3c80ed94f"},
            new[]{"Tengami_2160p", "8e9f7292c80ed94f"},
            new[]{"Tengami_2880p", "8e1f5193c80ed94f"},
            new[]{"Tengami_360p", "7f2605911db29ffc"},
            new[]{"Tengami_540p", "7fa6c5911db29ffc"},
            new[]{"TheWindWaker_1080pUW", "b86807f13d4ad2b8"},
            new[]{"TheWindWaker_1440p", "1dc4742849e33e49"},
            new[]{"TheWindWaker_1800p", "1dc4f52949e33e49"},
            new[]{"TheWindWaker_2160p", "1d44d41849e33e49"},
            new[]{"TheWindWaker_2160pUW", "b86807113546d2b8"},
            new[]{"TheWindWaker_2880p", "1dc4f71949e33e49"},
            new[]{"TheWindWaker_360p", "c86b1092c67d92da"},
            new[]{"TheWindWaker_4320p", "1d44957849e33e49"},
            new[]{"TheWindWaker_540p", "c8ebd092c67d92da"},
            new[]{"TheWindWaker_5760p", "1d44146849e33e49"},
            new[]{"TheWindWaker_720p", "c86b9192c67d92da"},
            new[]{"TheWindWaker_AARemoval", "d85e6e09e8562cc2"},
            new[]{"TheWindWaker_AdjustableBloom", "455042b526607d2e"},
            new[]{"TheWindWaker_HighResShadows", "fcef7b45e0be78c1"},
            new[]{"TNTRacers_1440p", "812bd08eec23e94f"},
            new[]{"TNTRacers_1800p", "812b518fec23e94f"},
            new[]{"TNTRacers_2160p", "81ab70beec23e94f"},
            new[]{"TNTRacers_360p", "17225dd947d29fe2"},
            new[]{"TNTRacers_540p", "17a29dd947d29fe2"},
            new[]{"TNTRacers_720p", "1722dcd947d29fe2"},
            new[]{"TokyoMirage_1080p", "8a88130290728a5a"},
            new[]{"TokyoMirage_1440p", "8a88900290728a5a"},
            new[]{"TokyoMirage_1800p", "8a88110390728a5a"},
            new[]{"TokyoMirage_2160p", "8a08303290728a5a"},
            new[]{"TokyoMirage_360p", "51a34520e514b5f4"},
            new[]{"TokyoMirage_540p", "51238520e514b5f4"},
            new[]{"TropicalFreeze_1080p", "79aca54871199e2a"},
            new[]{"TropicalFreeze_1080pUW", "50701e6b29525c86"},
            new[]{"TropicalFreeze_1440p", "79ac264871199e2a"},
            new[]{"TropicalFreeze_1800p", "79aca74971199e2a"},
            new[]{"TropicalFreeze_2160p", "792c867871199e2a"},
            new[]{"TropicalFreeze_2160pUW", "50701e8b215e5c86"},
            new[]{"TropicalFreeze_360p", "18cfd0e2323c5512"},
            new[]{"TropicalFreeze_540p", "184f10e2323c5512"},
            new[]{"TropicalFreeze_AARemoval", "7b51544f6e702944"},
            new[]{"TurboSuperStuntSquad_1080p", "75afef5e2f9d935a"},
            new[]{"TurboSuperStuntSquad_1440p", "75af6c5e2f9d935a"},
            new[]{"TurboSuperStuntSquad_1800p", "75afed5f2f9d935a"},
            new[]{"TurboSuperStuntSquad_2160p", "752fcc6e2f9d935a"},
            new[]{"TurboSuperStuntSquad_2880p", "75afef6f2f9d935a"},
            new[]{"TurboSuperStuntSquad_360p", "1e5bfc5e3a27b50a"},
            new[]{"TurboSuperStuntSquad_4320p", "752f8d0e2f9d935a"},
            new[]{"TurboSuperStuntSquad_540p", "1edb3c5e3a27b50a"},
            new[]{"TurboSuperStuntSquad_5760p", "752f0c1e2f9d935a"},
            new[]{"TwilightPrincess_1440p", "dc808e4b314b0106"},
            new[]{"TwilightPrincess_1800p", "dc800f4a314b0106"},
            new[]{"TwilightPrincess_2160p", "dc002e7b314b0106"},
            new[]{"TwilightPrincess_2880p", "dc800d7a314b0106"},
            new[]{"TwilightPrincess_360p", "419fd76296020c58"},
            new[]{"TwilightPrincess_4320p", "dc006f1b314b0106"},
            new[]{"TwilightPrincess_540p", "411f176296020c58"},
            new[]{"TwilightPrincess_5760p", "dc00ee0b314b0106"},
            new[]{"TwilightPrincess_720p", "419f566296020c58"},
            new[]{"TwilightPrincess_AARemoval", "5fa49d1da4f21344"},
            new[]{"TwilightPrincess_Bloom", "416f9870344b0106"},
            new[]{"TwilightPrincess_HighResShadows", "9ccd8674dc6ae766"},
            new[]{"Wipeout3_2880p", "d0274e1021d7bcf4"},
            new[]{"Wipeout3_4320p", "d0a72c7121d7bcf4"},
            new[]{"Wipeout3_5760p", "d0a7ad6121d7bcf4"},
            new[]{"WipeoutCreate&Crash_2880p", "1edeae86942f2ed3"},
            new[]{"WipeoutCreate&Crash_4320p", "1e5ecce7942f2ed3"},
            new[]{"WipeoutCreate&Crash_5760p", "1e5e4df7942f2ed3"},
            new[]{"Wipeout_1080p", "0f9860a2c87ae941"},
            new[]{"Wipeout_1440p", "0f98e3a2c87ae941"},
            new[]{"Wipeout_1800p", "0f9862a3c87ae941"},
            new[]{"Wipeout_2160p", "0f184392c87ae941"},
            new[]{"Wipeout_360p", "70450591f5d283fe"},
            new[]{"Wipeout_540p", "70c5c591f5d283fe"},
            new[]{"Wonderful101_1080p", "9b84374905f91292"},
            new[]{"Wonderful101_1440p", "9b84b44905f91292"},
            new[]{"Wonderful101_1800p", "9b84354805f91292"},
            new[]{"Wonderful101_2160p", "9b04147905f91292"},
            new[]{"Wonderful101_360p", "49ebd30af22524d7"},
            new[]{"Wonderful101_540p", "496b130af22524d7"},
            new[]{"XCX_1080p", "4b9b24f62126fc49"},
            new[]{"XCX_1080pUW", "88e8d226897d8809"},
            new[]{"XCX_1440p", "4b9ba7f62126fc49"},
            new[]{"XCX_1800p", "4b9b26f72126fc49"},
            new[]{"XCX_2160p", "4b1b07c62126fc49"},
            new[]{"XCX_2880p", "4b9b24c72126fc49"},
            new[]{"XCX_360p", "76cdad434cf89376"},
            new[]{"XCX_4320p", "4b1b46a62126fc49"},
            new[]{"XCX_540p", "764d6d434cf89376"},
            new[]{"XCX_5760p", "4b1bc7b62126fc49"},
            new[]{"XCX_AARemoval", "8e7262691d63c14f"},
            new[]{"XCX_AdjustableBrightness", "7ba9b8bb070ea012"},
            new[]{"XCX_AMDGCN4", "4b2536ec643f8909"},
            new[]{"XCX_HighResShadows", "5740122a54dc19c1"},
            new[]{"Yoshi'sWoollyWorld_2880p", "6e1dd689d53b285e"},
            new[]{"Yoshi'sWoollyWorld_4320p", "6e9db4e8d53b285e"},
            new[]{"Yoshi'sWoollyWorld_5760p", "6e9d35f8d53b285e"},
            new[]{"Yoshi_1080p", "49cac0b6f11ee702"},
            new[]{"Yoshi_1080pUW", "4e7a9232b06dbcc7"},
            new[]{"Yoshi_1440p", "49ca43b6f11ee702"},
            new[]{"Yoshi_1800p", "49cac2b7f11ee702"},
            new[]{"Yoshi_2160p", "494ae386f11ee702"},
            new[]{"Yoshi_360p", "d4052ce33dce0572"},
            new[]{"Yoshi_540p", "d485ece33dce0572"}
        };
    }
}
