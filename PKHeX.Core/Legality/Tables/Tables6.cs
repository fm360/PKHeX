﻿using System.Collections.Generic;
using System.Linq;

namespace PKHeX.Core
{
    public static partial class Legal
    {
        internal const int MaxSpeciesID_6 = 721;
        internal const int MaxMoveID_6_XY = 617;
        internal const int MaxMoveID_6_AO = 621;
        internal const int MaxItemID_6_XY = 717;
        internal const int MaxItemID_6_AO = 775;
        internal const int MaxAbilityID_6_XY = 188;
        internal const int MaxAbilityID_6_AO = 191;
        internal const int MaxBallID_6 = 0x19;
        internal const int MaxGameID_6 = 27; // OR

        #region Met Locations
        public static readonly int[] Met_XY_0 =
        {
   /* XY */ 2, 6, 8, 10, 12, 14, 16, 17, 18, 20, 22, 24, 26, 28, 30, 32,
            34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58, 60, 62, 64, 66, 68, 70, 72, 74, 76, 78, 82, 84, 86, 88,
            90, 92, 94, 96, 98, 100, 102, 104, 106, 108, 110, 112, 114, 116, 118, 120, 122, 124, 126, 128, 130, 132, 134,
            136, 138, 140, 142, 144, 146, 148, 150, 152, 154, 156, 158, 160, 162, 164, 166, 168, /* ORAS */ 170, 172,
            174, 176, 178, 180, 182, 184, 186, 188, 190, 192, 194, 196, 198, 200, 202, 204, 206, 208, 210, 212, 214, 216,
            218, 220, 222, 224, 226, 228, 230, 232, 234, 236, 238, 240, 242, 244, 246, 248, 250, 252, 254, 256, 258, 260,
            262, 264, 266, 268, 270, 272, 274, 276, 278, 280, 282, 284, 286, 288, 290, 292, 294, 296, 298, 300, 302, 304,
            306, 308, 310, 312, 314, 316, 318, 320, 322, 324, 326, 328, 330, 332, 334, 336, 338, 340, 342, 344, 346, 348,
            350, 352, 354,
        };

        internal static readonly int[] Met_XY_3 =
        {
            30001, 30003, 30004, 30005, 30006, 30007, 30008, 30009, 30010, 30011,
        };

        internal static readonly int[] Met_XY_4 =
        {
            40001, 40002, 40003, 40004, 40005, 40006, 40007, 40008, 40009, 40010,
            40011, 40012, 40013, 40014, 40015, 40016, 40017, 40018, 40019, 40020, 40021, 40022, 40023, 40024, 40025,
            40026, 40027, 40028, 40029, 40030, 40031, 40032, 40033, 40034, 40035, 40036, 40037, 40038, 40039, 40040,
            40041, 40042, 40043, 40044, 40045, 40046, 40047, 40048, 40049, 40050, 40051, 40052, 40053, 40054, 40055,
            40056, 40057, 40058, 40059, 40060, 40061, 40062, 40063, 40064, 40065, 40066, 40067, 40068, 40069, 40070,
            40071, 40072, 40073, 40074, 40075, 40076, 40077, 40078, 40079,
        };

        internal static readonly int[] Met_XY_6 = {/* XY */ 60001, 60003, /* ORAS */ 60004,};

        #endregion

        #region Inventory Pouch

        internal static readonly ushort[] Pouch_Items_XY =
        {
                 001, 002, 003, 004, 005, 006, 007, 008, 009, 010, 011, 012, 013, 014, 015, 016, 055, 056,
            057, 058, 059, 060, 061, 062, 063, 064, 065, 066, 067, 068, 069, 070, 071, 072, 073, 074, 075,
            076, 077, 078, 079, 080, 081, 082, 083, 084, 085, 086, 087, 088, 089, 090, 091, 092, 093, 094,
            099, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 112, 116, 117, 118, 119, 135, 136,
            213, 214, 215, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232,
            233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251,
            252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264, 265, 266, 267, 268, 269, 270,
            271, 272, 273, 274, 275, 276, 277, 278, 279, 280, 281, 282, 283, 284, 285, 286, 287, 288, 289,
            290, 291, 292, 293, 294, 295, 296, 297, 298, 299, 300, 301, 302, 303, 304, 305, 306, 307, 308,
            309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319, 320, 321, 322, 323, 324, 325, 326, 327,
            492, 493, 494, 495, 496, 497, 498, 499, 500, 537, 538, 539, 540, 541, 542, 543, 544, 545, 546,
            547, 548, 549, 550, 551, 552, 553, 554, 555, 556, 557, 558, 559, 560, 561, 562, 563, 564, 571,
            572, 573, 576, 577, 580, 581, 582, 583, 584, 585, 586, 587, 588, 589, 590, 639, 640, 644, 646,
            647, 648, 649, 650, 652, 653, 654, 655, 656, 657, 658, 659, 660, 661, 662, 663, 664, 665, 666,
            667, 668, 669, 670, 671, 672, 673, 674, 675, 676, 677, 678, 679, 680, 681, 682, 683, 684, 685,
            699, 704, 710, 711, 715,
        };

        internal static readonly ushort[] Pouch_Items_AO =
        {
                 001, 002, 003, 004, 005, 006, 007, 008, 009, 010, 011, 012, 013, 014, 015, 016, 055, 056,
            057, 058, 059, 060, 061, 062, 063, 064, 068, 069, 070, 071, 072, 073, 074, 075,
            076, 077, 078, 079, 080, 081, 082, 083, 084, 085, 086, 087, 088, 089, 090, 091, 092, 093, 094,
            099, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 112, 116, 117, 118, 119, 135, 136,
            213, 214, 215, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232,
            233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251,
            252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264, 265, 266, 267, 268, 269, 270,
            271, 272, 273, 274, 275, 276, 277, 278, 279, 280, 281, 282, 283, 284, 285, 286, 287, 288, 289,
            290, 291, 292, 293, 294, 295, 296, 297, 298, 299, 300, 301, 302, 303, 304, 305, 306, 307, 308,
            309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319, 320, 321, 322, 323, 324, 325, 326, 327,
            492, 493, 494, 495, 496, 497, 498, 499, 500, 537, 538, 539, 540, 541, 542, 543, 544, 545, 546,
            547, 548, 549, 550, 551, 552, 553, 554, 555, 556, 557, 558, 559, 560, 561, 562, 563, 564, 571,
            572, 573, 576, 577, 580, 581, 582, 583, 584, 585, 586, 587, 588, 589, 590, 639, 640, 644, 646,
            647, 648, 649, 650, 652, 653, 654, 655, 656, 657, 658, 659, 660, 661, 662, 663, 664, 665, 666,
            667, 668, 669, 670, 671, 672, 673, 674, 675, 676, 677, 678, 679, 680, 681, 682, 683, 684, 685,
            699, 704, 710, 711, 715,

            // ORAS
            534, 535,
            752, 753, 754, 755, 756, 757, 758, 759, 760, 761, 762, 763, 764, 767, 768, 769, 770,
        };

        internal static readonly ushort[] Pouch_Key_XY =
        {
                 216, 431, 442, 445, 446, 447, 450, 465, 466, 471, 628,
            629, 631, 632, 638, 641, 642, 643, 689, 695, 696, 697, 698,
            700, 701, 702, 703, 705, 712, 713, 714,

            // Illegal
            // 716, 717, 706, 707,
        };

        internal static readonly ushort[] Pouch_Key_AO =
        {
                 216, 445, 446, 447, 465, 466, 471, 628,
            629, 631, 632, 638, 697,

            // Illegal
            // 716, 717, 723, 745, 746, 747, 748, 749, 750, 766,

            // ORAS
            457, 474, 503,

            718, 719,
            720, 721, 722,      724, 725, 726, 727, 728, 729,
            730, 731, 732, 733, 734, 735, 736, 738, 739,
            740, 741, 742, 743, 744,
            751,
            765, 771, 772, 774, 775,
        };

        internal static readonly ushort[] Pouch_TMHM_XY =
        {
            328, 329, 330, 331, 332, 333, 334, 335, 336, 337, 338, 339, 340, 341, 342, 343, 344, 345,
            346, 347, 348, 349, 350, 351, 352, 353, 354, 355, 356, 357, 358, 359, 360, 361, 362, 363,
            364, 365, 366, 367, 368, 369, 370, 371, 372, 373, 374, 375, 376, 377, 378, 379, 380, 381,
            382, 383, 384, 385, 386, 387, 388, 389, 390, 391, 392, 393, 394, 395, 396, 397, 398, 399,
            400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417,
            418, 419, 618, 619, 620, 690, 691, 692, 693, 694,

            420, 421, 422, 423, 424,
        };

        internal static readonly ushort[] Pouch_TMHM_AO =
        {
            328, 329, 330, 331, 332, 333, 334, 335, 336, 337, 338, 339, 340, 341, 342, 343, 344, 345,
            346, 347, 348, 349, 350, 351, 352, 353, 354, 355, 356, 357, 358, 359, 360, 361, 362, 363,
            364, 365, 366, 367, 368, 369, 370, 371, 372, 373, 374, 375, 376, 377, 378, 379, 380, 381,
            382, 383, 384, 385, 386, 387, 388, 389, 390, 391, 392, 393, 394, 395, 396, 397, 398, 399,
            400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417,
            418, 419, 618, 619, 620, 690, 691, 692, 693, 694,

            420, 421, 422, 423, 424,

            // ORAS
            425, 737,
        };

        internal static readonly ushort[] Pouch_Medicine_XY =
        {
                 017, 018, 019, 020, 021, 022, 023, 024, 025, 026, 027, 028, 029, 030, 031, 032, 033,
            034, 035, 036, 037, 038, 039, 040, 041, 042, 043, 044, 045, 046, 047, 048, 049, 050, 051,
            052, 053, 054, 134, 504, 565, 566, 567, 568, 569, 570, 571, 591, 645, 708, 709,
        };

        internal static readonly ushort[] Pouch_Medicine_AO =
        {
                 017, 018, 019, 020, 021, 022, 023, 024, 025, 026, 027, 028, 029, 030, 031, 032, 033,
            034, 035, 036, 037, 038, 039, 040, 041, 042, 043, 044, 045, 046, 047, 048, 049, 050, 051,
            052, 053, 054, 134, 504, 565, 566, 567, 568, 569, 570, 571, 591, 645, 708, 709,

            //ORAS
            065, 066, 067
        };

        public static readonly ushort[] Pouch_Berry_XY =
        {
                 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162,
            163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177,
            178, 179, 180, 181, 182, 183, 184, 185, 186, 187, 188, 189, 190, 191, 192,
            193, 194, 195, 196, 197, 198, 199, 200, 201, 202, 203, 204, 205, 206, 207,
            208, 209, 210, 211, 212, 686, 687, 688,
        };

        internal static readonly ushort[] HeldItem_XY = new ushort[1].Concat(Pouch_Items_XY).Concat(Pouch_Medicine_XY).Concat(Pouch_Berry_XY).ToArray();
        internal static readonly ushort[] HeldItem_AO = new ushort[1].Concat(Pouch_Items_AO).Concat(Pouch_Medicine_AO).Concat(Pouch_Berry_XY).ToArray();
        #endregion

        #region TMHM

        internal static readonly int[] TMHM_AO =
        {
            468, 337, 473, 347, 046, 092, 258, 339, 474, 237,
            241, 269, 058, 059, 063, 113, 182, 240, 355, 219,
            218, 076, 479, 085, 087, 089, 216, 091, 094, 247,
            280, 104, 115, 482, 053, 188, 201, 126, 317, 332,
            259, 263, 488, 156, 213, 168, 490, 496, 497, 315,
            211, 411, 412, 206, 503, 374, 451, 507, 510, 511,
            261, 512, 373, 153, 421, 371, 514, 416, 397, 148,
            444, 521, 086, 360, 014, 522, 244, 523, 524, 157,
            404, 525, 611, 398, 138, 447, 207, 214, 369, 164,
            430, 433, 528, 290, 555, 267, 399, 612, 605, 590,

            15, 19, 57, 70, 127, 249, 291,
        };

        internal static readonly int[] TMHM_XY =
        {
            468, 337, 473, 347, 046, 092, 258, 339, 474, 237,
            241, 269, 058, 059, 063, 113, 182, 240, 355, 219,
            218, 076, 479, 085, 087, 089, 216, 091, 094, 247,
            280, 104, 115, 482, 053, 188, 201, 126, 317, 332,
            259, 263, 488, 156, 213, 168, 490, 496, 497, 315,
            211, 411, 412, 206, 503, 374, 451, 507, 510, 511,
            261, 512, 373, 153, 421, 371, 514, 416, 397, 148,
            444, 521, 086, 360, 014, 522, 244, 523, 524, 157,
            404, 525, 611, 398, 138, 447, 207, 214, 369, 164,
            430, 433, 528, 249, 555, 267, 399, 612, 605, 590,

            15, 19, 57, 70, 127,
        };

        internal static readonly int[] TypeTutor6 =
        {
            520, 519, 518, // Pledge
            338, 307, 308, // Elemental Beam
            434, // Draco Meteor
            620, // Dragon Ascent
        };

        internal static readonly int[][] Tutors_AO =
        {
            new[] {450, 343, 162, 530, 324, 442, 402, 529, 340, 067, 441, 253, 009, 007, 008},
            new[] {277, 335, 414, 492, 356, 393, 334, 387, 276, 527, 196, 401, 399, 428, 406, 304, 231},
            new[] {020, 173, 282, 235, 257, 272, 215, 366, 143, 220, 202, 409, 355, 264, 351, 352},
            new[] {380, 388, 180, 495, 270, 271, 478, 472, 283, 200, 278, 289, 446, 214, 285},
        };

        #endregion

        internal static readonly int[] EggLocations6 = {Locations.Daycare5, Locations.LinkTrade6};

        internal static readonly HashSet<int> ValidMet_XY = new HashSet<int>
        {
            006, 008, 009, 010, 012, 013, 014, 016, 017, 018, 020, 021, 022, 024, 026, 028, 029, 030, 032, 034, 035, 036,
            038, 039, 040, 042, 043, 044, 046, 047, 048, 050, 051, 052, 054, 055, 056, 058, 060, 062, 063, 064, 066, 067,
            068, 069, 070, 072, 074, 075, 076, 078, 079, 082, 084, 085, 086, 088, 089, 090, 092, 093, 094, 096, 097, 098,
            100, 101, 102, 103, 104, 106, 108, 110, 112, 114, 116, 118, 120, 122, 124, 126, 128, 130, 132, 134, 135, 136,
            138, 140, 142, 144, 146, 148, 150, 152, 154, 156, 158, 160, 162, 164, 166, 168
        };

        internal static readonly HashSet<int> ValidMet_AO = new HashSet<int>
        {
            170, 172, 174, 176, 178, 180, 182, 184, 186, 188, 190, 192, 194, 196, 198,
            200, 202, 204, 206, 208, 210, 212, 214, 216, 218, 220, 222, 224, 226, 228, 230, 232, 234, 236, 238, 240, 242,
            244, 246, 248, 250, 252, 254, 256, 258, 260, 262, 264, 266, 268, 270, 272, 274, 276, 278, 280, 282, 284, 286,
            288, 290, 292, 294, 296, 298, 300, 302, 304, 306, 308, 310, 312, 314, 316, 318, 320, 322, 324, 326, 328, 330,
            332, 334, 336, 338, 340, 342, 344, 346,      350, 352, 354
        };

        internal static readonly HashSet<int> FriendSafari = new HashSet<int>
        {
            190, 206, 216, 506, 294, 352, 531, 572, 113, 132, 133, 235,
            012, 046, 165, 415, 267, 284, 313, 314, 049, 127, 214, 666,
            262, 274, 624, 629, 215, 332, 342, 551, 302, 359, 510, 686,
            444, 611, 148, 372, 714, 621, 705,
            101, 417, 587, 702, 025, 125, 618, 694, 310, 404, 523, 596,
            175, 209, 281, 702, 039, 303, 682, 684, 035, 670,
            056, 067, 307, 619, 538, 539, 674, 236, 286, 297, 447,
            058, 077, 126, 513, 005, 218, 636, 668, 038, 654, 662,
            016, 021, 083, 084, 163, 520, 527, 581, 357, 627, 662, 701,
            353, 608, 708, 710, 356, 426, 442, 623,
            043, 114, 191, 511, 002, 541, 548, 586, 556, 651, 673,
            027, 194, 231, 328, 051, 105, 290, 323, 423, 536, 660,
            225, 361, 363, 459, 215, 614, 712, 087, 091, 131, 221,
            014, 044, 268, 336, 049, 168, 317, 569, 089, 452, 454, 544,
            063, 096, 326, 517, 202, 561, 677, 178, 203, 575, 578,
            299, 525, 557, 095, 219, 222, 247, 112, 213, 689,
            082, 303, 597, 205, 227, 375, 600, 437, 530, 707,
            098, 224, 400, 515, 008, 130, 195, 419, 061, 184, 657
        };

        internal static readonly int[] CosplayPikachuMoves = { 309, 556, 577, 604, 560, 0 };
        internal static readonly HashSet<int> WildPokeballs6 = new HashSet<int> {0x01, 0x02, 0x03, 0x04, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F};

        internal static readonly HashSet<int> Ban_NoHidden6 = new HashSet<int>
        {
            //Not avaliable at Friend Safari or Horde Encounter
            669 + (2 << 11), //Flabébé-Orange
            670 + (2 << 11), //Floette-Orange
            671 + (2 << 11), //Florges-Orange
            669 + (4 << 11), //Flabébé-White
            670 + (4 << 11), //Floette-White
            671 + (4 << 11), //Florges-White

            710 + (1 << 11), //Pumpkaboo-Small
            711 + (1 << 11), //Gourgeist-Small
            710 + (2 << 11), //Pumpkaboo-Large
            711 + (2 << 11), //Gourgeist-Large
            //Super Size can be obtained as a Pumpkaboo from event distributions

            // Same abilities (1/2/H), not available as H
            (int)Species.Honedge,
            (int)Species.Doublade,
            (int)Species.Aegislash,
            (int)Species.Carnivine,
            (int)Species.Cryogonal,
            (int)Species.Archen,
            (int)Species.Archeops,
            (int)Species.Rotom,
            (int)Species.Rotom + (1 << 11),
            (int)Species.Rotom + (2 << 11),
            (int)Species.Rotom + (3 << 11),
            (int)Species.Rotom + (4 << 11),
            (int)Species.Rotom + (5 << 11),

            (int)Species.Castform,
            (int)Species.Furfrou,
        };
        #region Ball Table
        internal static readonly HashSet<int> Inherit_Sport = new HashSet<int>
        {
            010, 013, 046, 048, 123, 127, 265, 290, 314, 401, 415,

            313, // Via Illumise
        };

        internal static readonly HashSet<int> Inherit_Safari = new HashSet<int>
        {
            016, 019, 020, 021, 022, 023, 024, 025, 027, 029, 035, 039, 041,
            043, 046, 048, 050, 054, 055, 060, 063, 066, 069, 070, 074, 077, 079, 080, 083, 084, 088, 092, 095, 096, 098,
            099, 102, 104, 108, 109, 111, 113, 114, 115, 118, 122, 123, 125, 126, 127, 129, 131, 147, 161, 163, 165, 167,
            177, 179, 183, 187, 189, 190, 191, 193, 194, 198, 200, 202, 203, 204, 207, 209, 213, 214, 216, 223, 228, 229,
            231, 234, 235, 241, 246, 263, 264, 270, 271, 273, 283, 284, 285, 286, 288, 298, 299, 304, 305, 307, 308, 309,
            310, 314, 315, 316, 318, 324, 327, 328, 331, 332, 335, 336, 339, 341, 352, 353, 354, 355, 356, 357, 358, 363,
            364, 371, 372, 396, 399, 400, 403, 404, 406, 417, 418, 419, 433, 443, 447, 449, 451, 453, 455,

            032, // Via Nidoran-F
            313, // Via Illumise

            172, // Via Pikachu
            173, // Via Clefairy
            174, // Via Jigglypuff
            239, // Via Electabuzz
            240, // Via Magmar
            298, // Via Marill
            360, // Via Wobbuffet
            406, // Via Roselia
            433, // Via Chimecho
            439, // Via Mr. Mime
            440, // Via Chansey

            287, // Via Vigoroth
        };

        internal static readonly HashSet<int> Inherit_Dream = new HashSet<int>
        {
            010, 013, 016, 019, 021, 023, 027, 029, 037, 041, 043, 046, 048, 050, 052, 054, 056, 058, 060, 063, 066, 069,
            072, 074, 077, 079, 083, 084, 086, 088, 090, 092, 095, 096, 098, 102, 104, 108, 109, 111, 113, 114, 115, 116,
            118, 122, 123, 127, 129, 131, 133, 138, 140, 142, 143, 147, 161, 163, 165, 167, 170, 173, 174, 175, 177, 179,
            183, 185, 187, 190, 191, 193, 194, 198, 200, 202, 203, 204, 206, 207, 209, 211, 213, 214, 215, 216, 218, 220,
            222, 223, 225, 226, 227, 228, 231, 234, 235, 238, 239, 240, 241, 246, 261, 263, 265, 270, 273, 276, 278, 280,
            283, 285, 287, 290, 293, 296, 299, 300, 302, 303, 304, 307, 309, 311, 312, 314, 315, 316, 318, 320, 322, 324,
            325, 327, 328, 331, 333, 335, 336, 339, 341, 345, 347, 349, 351, 352, 353, 355, 357, 358, 359, 361, 363, 366,
            369, 370, 371, 396, 399, 401, 403, 408, 410, 412, 415, 417, 418, 420, 422, 425, 427, 431, 434, 441, 442, 443,
            447, 449, 451, 453, 455, 456, 459, 517, 519, 525, 529, 531, 533, 535, 545, 546, 548, 550, 553, 556, 558, 559,
            561, 564, 578, 580, 583, 587, 588, 594, 596, 605, 610, 616, 618, 621, 624, 631, 632,

            032, // Via Nidoran-F
            313, // Via Illumise

            // Via Evolution
            524, // Roggenrola
            532, // Timburr
            543, // Venipede
            551, // Sandile
            557, // Dwebble
            577, // Solosis
            582, // Vanillite
            595, // Joltik

            // Via Incense Breeding
            298, 360, 406, 433, 438, 439, 440, 446, 458,
        };

        internal static readonly HashSet<int> Ban_DreamHidden = new HashSet<int>
        {
            311, // Plusle
            312, // Minun
            352, // Kecleon
            355, // Duskull

            // Via Pre-Evolution
            356, // Dusclops
            477, // Dusknoir
        };

        internal static readonly HashSet<int> Ban_Gen3Ball = new HashSet<int>
        {
            252, 255, 258, //1 - Treeko, Torchic, Mudkip
            253, 256, 259, //2
            254, 257, 260, //3
            387, 390, 393, //1 - Turtwig, Chimchar, Piplup
            388, 391, 394, //2
            389, 392, 395, //3
            495, 498, 501, //1 - Snivy, Tepig, Oshawott
            496, 499, 502, //2
            497, 500, 503, //3
            566, 567, 696, 697, 698, 699 // Fossil Only obtain
        };

        internal static readonly HashSet<int> Ban_Gen3BallHidden = new HashSet<int>
        {
            // can have HA and can be in gen 3 ball as eggs but can not at same time.
            152, 155, 158, //1 - Gen2 Starters
            153, 156, 159, //2
            154, 157, 160, //3
            585 + (1 << 11), //Deerling-Summer
            586 + (1 << 11), //Sawsbuck-Summer
            585 + (2 << 11), //Deerling-Autumn
            586 + (2 << 11), //Sawsbuck-Autumn
            585 + (3 << 11), //Deerling-Winter
            586 + (3 << 11), //Sawsbuck-Winter
            710 + (3 << 11), //Pumpkaboo-Super
            711 + (3 << 11), //Gourgeist-Super
        };

        internal static readonly HashSet<int> Ban_Gen4Ball_6 = new HashSet<int>
        {
            152, 155, 158, //1 - Chikorita, Cyndaquil, Totodile
            153, 156, 159, //2
            154, 157, 160, //3
            252, 255, 258, //1 - Treeko, Torchic, Mudkip
            253, 256, 259, //2
            254, 257, 260, //3
            387, 390, 393, //1 - Turtwig, Chimchar, Piplup
            388, 391, 394, //2
            389, 392, 395, //3
            495, 498, 501, //1 - Snivy, Tepig, Oshawott
            496, 499, 502, //2
            497, 500, 503, //3
            566, 567, 696, 697, 698, 699 // Fossil Only obtain
        };
        #endregion

        internal static readonly byte[] MovePP_XY =
        {
            00,
            35, 25, 10, 15, 20, 20, 15, 15, 15, 35, 30, 05, 10, 20, 30, 35, 35, 20, 15, 20, 20, 25, 20, 30, 05, 10, 15, 15, 15, 25, 20, 05, 35, 15, 20, 20, 10, 15, 30, 35, 20, 20, 30, 25, 40, 20, 15, 20, 20, 20,
            30, 25, 15, 30, 25, 05, 15, 10, 05, 20, 20, 20, 05, 35, 20, 25, 20, 20, 20, 15, 25, 15, 10, 20, 25, 10, 35, 30, 15, 10, 40, 10, 15, 30, 15, 20, 10, 15, 10, 05, 10, 10, 25, 10, 20, 40, 30, 30, 20, 20,
            15, 10, 40, 15, 10, 30, 10, 20, 10, 40, 40, 20, 30, 30, 20, 30, 10, 10, 20, 05, 10, 30, 20, 20, 20, 05, 15, 15, 20, 10, 15, 35, 20, 15, 10, 10, 30, 15, 40, 20, 15, 10, 05, 10, 30, 10, 15, 20, 15, 40,
            20, 10, 05, 15, 10, 10, 10, 15, 30, 30, 10, 10, 20, 10, 01, 01, 10, 25, 10, 05, 15, 25, 15, 10, 15, 30, 05, 40, 15, 10, 25, 10, 30, 10, 20, 10, 10, 10, 10, 10, 20, 05, 40, 05, 05, 15, 05, 10, 05, 10,
            10, 10, 10, 20, 20, 40, 15, 10, 20, 20, 25, 05, 15, 10, 05, 20, 15, 20, 25, 20, 05, 30, 05, 10, 20, 40, 05, 20, 40, 20, 15, 35, 10, 05, 05, 05, 15, 05, 20, 05, 05, 15, 20, 10, 05, 05, 15, 10, 15, 15,
            10, 10, 10, 20, 10, 10, 10, 10, 15, 15, 15, 10, 20, 20, 10, 20, 20, 20, 20, 20, 10, 10, 10, 20, 20, 05, 15, 10, 10, 15, 10, 20, 05, 05, 10, 10, 20, 05, 10, 20, 10, 20, 20, 20, 05, 05, 15, 20, 10, 15,
            20, 15, 10, 10, 15, 10, 05, 05, 10, 15, 10, 05, 20, 25, 05, 40, 15, 05, 40, 15, 20, 20, 05, 15, 20, 20, 15, 15, 05, 10, 30, 20, 30, 15, 05, 40, 15, 05, 20, 05, 15, 25, 25, 15, 20, 15, 20, 15, 20, 10,
            20, 20, 05, 05, 10, 05, 40, 10, 10, 05, 10, 10, 15, 10, 20, 15, 30, 10, 20, 05, 10, 10, 15, 10, 10, 05, 15, 05, 10, 10, 30, 20, 20, 10, 10, 05, 05, 10, 05, 20, 10, 20, 10, 15, 10, 20, 20, 20, 15, 15,
            10, 15, 15, 15, 10, 10, 10, 20, 10, 30, 05, 10, 15, 10, 10, 05, 20, 30, 10, 30, 15, 15, 15, 15, 30, 10, 20, 15, 10, 10, 20, 15, 05, 05, 15, 15, 05, 10, 05, 20, 05, 15, 20, 05, 20, 20, 20, 20, 10, 20,
            10, 15, 20, 15, 10, 10, 05, 10, 05, 05, 10, 05, 05, 10, 05, 05, 05, 15, 10, 10, 10, 10, 10, 10, 15, 20, 15, 10, 15, 10, 15, 10, 20, 10, 15, 10, 20, 20, 20, 20, 20, 15, 15, 15, 15, 15, 15, 20, 15, 10,
            15, 15, 15, 15, 10, 10, 10, 10, 10, 15, 15, 15, 15, 05, 05, 15, 05, 10, 10, 10, 20, 20, 20, 10, 10, 30, 15, 15, 10, 15, 25, 10, 15, 10, 10, 10, 20, 10, 10, 10, 10, 10, 15, 15, 05, 05, 10, 10, 10, 05,
            05, 10, 05, 05, 15, 10, 05, 05, 05, 10, 10, 10, 10, 20, 25, 10, 20, 30, 25, 20, 20, 15, 20, 15, 20, 20, 10, 10, 10, 10, 10, 20, 10, 30, 15, 10, 10, 10, 20, 20, 05, 05, 05, 20, 10, 10, 20, 15, 20, 20,
            10, 20, 30, 10, 10, 40, 40, 30, 20, 40, 20, 20, 10, 10, 10, 10, 05, 10, 10, 05, 05,
        };

        internal static readonly int[] UnreleasedItems_6 =
        {
            005, // Safari Ball
            016, // Cherish Ball
            492, // Fast Ball
            493, // Level Ball
            494, // Lure Ball
            495, // Heavy Ball
            496, // Love Ball
            497, // Friend Ball
            498, // Moon Ball
            499, // Sport Ball
            500, // Park Ball
            548, // Fire Gem
            549, // Water Gem
            550, // Electric Gem
            551, // Grass Gem
            552, // Ice Gem
            553, // Fighting Gem
            554, // Poison Gem
            555, // Ground Gem
            556, // Flying Gem
            557, // Psychic Gem
            558, // Bug Gem
            559, // Rock Gem
            560, // Ghost Gem
            561, // Dragon Gem
            562, // Dark Gem
            563, // Steel Gem
            576, // Dream Ball
            584, // Relic Copper
            585, // Relic Silver
            587, // Relic Vase
            588, // Relic Band
            589, // Relic Statue
            590, // Relic Crown
            715, // Fairy Gem
        };

        internal static readonly bool[] ReleasedHeldItems_6 = Enumerable.Range(0, MaxItemID_6_AO+1).Select(i => HeldItem_AO.Contains((ushort)i) && !UnreleasedItems_6.Contains(i)).ToArray();
    }
}
