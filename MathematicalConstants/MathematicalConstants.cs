using System;
using System.Text;

namespace MathematicalConstants
{
    /// <summary>
    /// Mathmetical Constants Helpers
    /// </summary>
    public partial class MathematicalConstants
    {
        /// <summary>
        /// Convert string data to int32.
        /// </summary>
        /// <param name="data">String format of data provided by MathematicalConstants.</param>
        /// <param name="startIndex">Starting index. Must be higher than 1.</param>
        /// <param name="endIndex">Ending index. Must be equal or higher than startingIndex.</param>
        /// <returns>integer of conversion.</returns>
        /// <exception cref="Exception">Throws exception if startingIndex and endingIndex is negative. Throws exception if endIndex is lower than startIndex. Throws exception if startIndex is lower than 1. Throws exception if converted data overflows int32.</exception>
        public static int ToInt32(string data, int startIndex, int endIndex)
        {
            if (startIndex < 0 && endIndex < 0)
            {
                throw new Exception("startIndex and endIndex must be positive numbers.");
            }

            if (endIndex < startIndex)
            {
                throw new Exception("endIndex must be higher than startIndex");
            }

            if (startIndex < 1)
            {
                throw new Exception("startIndex must be higher than in order to return integer data.");
            }

            int.TryParse(data.Substring(startIndex, (endIndex - startIndex)), out int result);

            return result;
        }

        /// <summary>
        /// Convert string data to int64.
        /// </summary>
        /// <param name="data">String format of data provided by MathematicalConstants.</param>
        /// <param name="startIndex">Starting index. Must be higher than 1.</param>
        /// <param name="endIndex">Ending index. Must be equal or higher than startingIndex.</param>
        /// <returns>integer of conversion.</returns>
        /// <exception cref="Exception">Throws exception if startingIndex and endingIndex is negative. Throws exception if endIndex is lower than startIndex. Throws exception if startIndex is lower than 1. Throws exception if converted data overflows int64.</exception>
        public static long ToInt64(string data, int startIndex, int endIndex)
        {
            if (startIndex < 0 && endIndex < 0)
            {
                throw new Exception("startIndex and endIndex must be positive numbers.");
            }

            if (endIndex < startIndex)
            {
                throw new Exception("endIndex must be higher than startIndex");
            }

            if (startIndex < 1)
            {
                throw new Exception("startIndex must be higher than in order to return integer data.");
            }

            long.TryParse(data.Substring(startIndex, (endIndex - startIndex)), out long result);

            return result;
        }

        /// <summary>
        /// Convert string data to double.
        /// </summary>
        /// <param name="data">String format of data provided by MathematicalConstants.</param>
        /// <param name="startIndex">Starting index.</param>
        /// <param name="endIndex">Ending index. Must be equal or higher than startingIndex.</param>
        /// <returns>integer of conversion.</returns>
        /// <exception cref="Exception">Throws exception if startingIndex and endingIndex is negative. Throws exception if endIndex is lower than startIndex. Throws exception if converted data overflows int32.</exception>
        public static double ToDouble(string data, int startIndex, int endIndex)
        {
            if (startIndex < 0 && endIndex < 0)
            {
                throw new Exception("startIndex and endIndex must be positive numbers.");
            }

            if (endIndex < startIndex)
            {
                throw new Exception("endIndex must be higher than startIndex");
            }

            double result;

            if (startIndex < 1)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(data.Substring(startIndex, (endIndex - startIndex)));

                sb.Insert(1, ".");

                double.TryParse(sb.ToString(), out result);
            }
            else
            {
                double.TryParse(data.Substring(startIndex, (endIndex - startIndex)), out result);
            }

            return result;
        }

        /// <summary>
        /// Maximum available digits of number Phi. "1.6180..."
        /// </summary>
        public static int LengthPhi => PhiNumber.Length;

        /// <summary>
        /// Maximum available digits of number Pi. "3.1415..."
        /// </summary>
        public static int LengthPi => PiNumber.Length;

        /// <summary>
        /// Maximum available digits of number (Euler) E. "2.7182..."
        /// </summary>
        public static int LengthE => ENumber.Length;

        /// <summary>
        /// Maximum available digits of square root of 2. "1.4142..."
        /// </summary>
        public static int LengthSquareRootOfTwo => SquareRootOfTwo.Length;

        /// <summary>
        /// Maximum available digits of square root of 3. "1.7320..."
        /// </summary>
        public static int LengthSquareRootOfThree => SquareRootOfThree.Length;

        /// <summary>
        /// Maximum available digits of square root of 5. "2.2360..."
        /// </summary>
        public static int LengthSquareRootOfFive => SquareRootOfFive.Length;

        /// <summary>
        /// Maximum available digits of Apery. "1.2020..."
        /// </summary>
        public static int LengthApery => Apery.Length;

        /// <summary>
        /// Maximum available digits of Artin. "0.3739"
        /// </summary>
        public static int LengthArtin => Artin.Length;

        /// <summary>
        /// Maximum available digits of Backhouse. "0.4560..."
        /// </summary>
        public static int LengthBackhouse => Backhouse.Length;

        /// <summary>
        /// Maximum available digits of Bernstein. "0.2801..."
        /// </summary>
        public static int LengthBernstein => Bernstein.Length;

        /// <summary>
        /// Maximum available digits of Brun Twin Primes. "1.9021..."
        /// </summary>
        public static int LengthBrunTwinPrimes => BrunTwoPrimes.Length;

        /// <summary>
        /// Maximum available digits of Cahen. "0.6434..."
        /// </summary>
        public static int LengthCahen => Cahen.Length;

        /// <summary>
        /// Maximum available digits of Catalan. "0.9159..."
        /// </summary>
        public static int LengthCatalan => Catalan.Length;

        /// <summary>
        /// Maximum available digits of Champernowne. "0.1234..."
        /// </summary>
        public static int LengthChampernowne => Champernowne.Length;

        /// <summary>
        /// Maximum available digits of Conway. "1.3035..."
        /// </summary>
        public static int LengthConway => Conway.Length;

        /// <summary>
        /// Maximum available digits of Copeland-Erdps "0.2357"
        /// </summary>
        public static int LengthCopelandErdos => CopelandErdos.Length;

        /// <summary>
        /// Maximum available digits of cube root of 2. "1.2599"
        /// </summary>
        public static int LengthCubeRootOfTwo => CubeRootOfTwo.Length;

        /// <summary>
        /// Maximum available digits of Copeland-Erdos. "1.0074..."
        /// </summary>
        public static int LengthDeVicciTesseract => DeVicciTesseract.Length;

        /// <summary>
        ///  Maximum available digits of Dottie. "0.7390..."
        /// </summary>
        public static int LengthDottieNumber => Dottie.Length;

        /// <summary>
        /// Maximum avaiable digits Erdos-Borwein. "1.6066..."
        /// </summary>
        public static int LengthErdosBorwein => ErdosBorwein.Length;

        /// <summary>
        /// Maximum avaiable digits Erdos-Tenenbaum-Ford. "0.6807..."
        /// </summary>
        public static int LengthErdosTenenbaumFord => ErdosTenenbaumFord.Length;

        /// <summary>
        /// Maximum available digits of Euler-Mascheroni. "0.5772..."
        /// </summary>
        public static int LengthEulerMascheorni => EulerMascheroni.Length;

        /// <summary>
        /// Maximum avaiable digits Feigenbaum. "2.5059..."
        /// </summary>
        public static int LengthFeigenbaum => Feigenbaum.Length;

        /// <summary>
        /// Maximum available digits of Feigenbaum2. "4.6692..."
        /// </summary>
        public static int LengthFeigenbaum2 => Feigenbaum2.Length;

        /// <summary>
        /// Maximum available digits of Foller-Tornier. "0.6613..."
        /// </summary>
        public static int LengthFellerTornier => FellerTornier.Length;

        /// <summary>
        /// Maximum available digits of Foias. "1.1874..."
        /// </summary>
        public static int LengthFoias => Foias.Length;

        /// <summary>
        /// Maximum available digits of Fransen-Robinson. "2.8077"
        /// </summary>
        public static int LengthFransenRobinson => FransenRobinson.Length;

        /// <summary>
        /// Maximum available digits of Gauss. "0.8346..."
        /// </summary>
        public static int LengthGauss => Gauss.Length;

        /// <summary>
        /// Maximum available digits of Gelfond-Schneider. "2.6651..."
        /// </summary>
        public static int LengthGelfondSchneider => GelfondSchneider.Length;

        /// <summary>
        /// Maximum available digits of Gieseking. "1.0149..."
        /// </summary>
        public static int LengthGieseking => Gieseking.Length;

        /// <summary>
        /// Maximum available digits of Glaisher-Kinkelin. "1.2824..."
        /// </summary>
        public static int LengthGlaisherKinkelin => GlaisherKinkelin.Length;

        /// <summary>
        /// Maximum available digits of Golden angle. "2.3999..."
        /// </summary>
        public static int LengthGoldenAngle => GoldenAngle.Length;

        /// <summary>
        /// Maximum available digits of Golomb-Dickman. "0.6601..."
        /// </summary>
        public static int LengthGolombDickman => GolombDickman.Length;

        /// <summary>
        /// Maximum available digits of Gombert. "0.5963..."
        /// </summary>
        public static int LengthGombert => Gombertz.Length;

        /// <summary>
        /// Maximum available digits of Hafner-Sarnak-McCurley. "0.3532..."
        /// </summary>
        public static int LengthHafnerSarnakMcCurley => HafnerSarnakMcCurley.Length;

        /// <summary>
        /// Maximum available digits of Heath-Brown-Moroz. "0.0013..."
        /// </summary>
        public static int LengthHeathBrownMoroz => HeathBrownMoroz.Length;

        /// <summary>
        /// Maximum available digits of Kepler-Bouwkamp. "0.1149..."
        /// </summary>
        public static int LengthKeplerBouwkamp => KeplerBouwkamp.Length;

        /// <summary>
        /// Maximum available digits of Khincin. "2.6854..."
        /// </summary>
        public static int LengthKhincin => Khinchin.Length;

        /// <summary>
        /// Maximum available digits of Komornik-Loreti. "1.7872..."
        /// </summary>
        public static int LengthKomornikLoreti => KomornikLoreti.Length;

        /// <summary>
        /// Maximum available digits of Landau-Ramanujan. "0.7642..."
        /// </summary>
        public static int LengthLandauRamanujan => LandauRamanujan.Length;

        /// <summary>
        /// Maximum available digits of Laplace Limit. "0.6627..."
        /// </summary>
        public static int LengthLaplaceLimit => LaplaceLimit.Length;

        /// <summary>
        /// Maximum available digits of Lemniscate. "2.6220..."
        /// </summary>
        public static int LengthLemniscate => Lemniscate.Length;

        /// <summary>
        /// Maximum available digits of Khincin. "3.2758..."
        /// </summary>
        public static int LengthLevy => Levy.Length;

        /// <summary>
        /// Maximum available digits of Levy2. "3.2758..."
        /// </summary>
        public static int LengthLevy2 => Levy2.Length;

        /// <summary>
        /// Maximum available digits of Liebs Square Ice. "1.5396..."
        /// </summary>
        public static int LengthLiebsSquareIce => LiebsSquareIce.Length;

        /// <summary>
        /// Maximum available digits of Lochs. "0.9702..."
        /// </summary>
        public static int LengthLochs => Lochs.Length;

        /// <summary>
        /// Maximum available digits of Magic angle. "0.9553..."
        /// </summary>
        public static int LengthMagicAngle => MagicAngle.Length;

        /// <summary>
        /// Maximum available digits of Meissel-Mertens. "0.2614..."
        /// </summary>
        public static int LengthMeisselMertens => MeisselMertents.Length;

        /// <summary>
        /// Maximum available digits of Mills. "1.3063..."
        /// </summary>
        public static int LengthMills => Mills.Length;

        /// <summary>
        /// Maximum available digits of MRB Marvin Ray Burns. "0.1878..."
        /// </summary>
        public static int LengthMRBMarvinRayBurns => MRBMarvinRayBurns.Length;

        /// <summary>
        /// Maximum available digits of Natural logarithm of two. "0.6931..."
        /// </summary>
        public static int LengthNaturalLogarithmOfTwo => NaturalLogarithmOfTwo.Length;

        /// <summary>
        /// Maximum available digits of Mills. "1.9599..."
        /// </summary>
        public static int LengthNigthySevenFivePercentile => NigthySevenFivePercentile.Length;

        /// <summary>
        /// Maximum available digits of Niven. "1.7052..."
        /// </summary>
        public static int LengthNiven => Niven.Length;

        /// <summary>
        /// Maximum available digits of Omega. "0.5671..."
        /// </summary>
        public static int LengthOmega => OmegaNumber.Length;

        /// <summary>
        /// Maximum available digits of Plastic. "1.3247"
        /// </summary>
        public static int LengthPlastic => Plastic.Length;

        /// <summary>
        /// Maximum available digits of Porter. "1.4670..."
        /// </summary>
        public static int LengthPorter => Porter.Length;

        /// <summary>
        /// Maximum available digits of Prime. "0.4146..."
        /// </summary>
        public static int LengthPrime => Prime.Length;

        /// <summary>
        /// Maximum available digits of Prouhet Thue Morse. "0.4124..."
        /// </summary>
        public static int LengthProuhetThueMorse => ProuhetThueMorse.Length;

        /// <summary>
        /// Maximum available digits of Ramanujan-Soldner. "1.4513..."
        /// </summary>
        public static int LengthRamanujanSoldner => RamanujanSoldner.Length;

        /// <summary>
        /// Maximum available digits of Reciprocal Fibonacci. "3.3598..."
        /// </summary>
        public static int LengthReciprocalFibonacci => ReciprocalFibonacci.Length;

        /// <summary>
        /// Maximum available digits of Regular Paperfolding Sequence. "0.8507..."
        /// </summary>
        public static int LengthRegularPaperfoldingSequence => RegularPaperfoldingSequence.Length;

        /// <summary>
        /// Maximum available digits of Robbins. "0.6617..."
        /// </summary>
        public static int LengthRobbins => Robbins.Length;

        /// <summary>
        /// Maximum available digits of Salem. "1.1762..."
        /// </summary>
        public static int LengthSalem => Salem.Length;

        /// <summary>
        /// Maximum available digits of Samos Quadratic Recurrence. "1.6616..."
        /// </summary>
        public static int LengthSamosQuadraticRecurrence => SamosQuadraticRecurrence.Length;

        /// <summary>
        /// Maximum available digits of SecondDuBoisReymond. "0.1945..."
        /// </summary>
        public static int LengthSecondDuBoisReymond => SecondDuBoisReymond.Length;

        /// <summary>
        /// Maximum available digits of Second Du Bois Reymond. "1.2337..."
        /// </summary>
        public static int LengthSecondFavard => SecondFavard.Length;

        /// <summary>
        /// Maximum available digits of Second Hermite. "1.1547..."
        /// </summary>
        public static int LengthSecondHermite => SecondHermite.Length;

        /// <summary>
        /// Maximum available digits of Sierpinski. "2.5849..."
        /// </summary>
        public static int LengthSierpinski => Sierpinski.Length;

        /// <summary>
        /// Maximum available digits of Silver Ratio. "2.4142..."
        /// </summary>
        public static int LengthSilverRatio => SilverRatio.Length;

        /// <summary>
        /// Maximum available digits of Stephens. "0.5759..."
        /// </summary>
        public static int LengthStephens => Stephens.Length;

        /// <summary>
        /// Maximum available digits of Super Golden Ratio. "1.4655..."
        /// </summary>
        public static int LengthSuperGoldenRatio => SuperGoldenRatio.Length;

        /// <summary>
        /// Maximum available digits of Taniguchi. "0.6782..."
        /// </summary>
        public static int LengthTaniguchi => Taniguchi.Length;

        /// <summary>
        /// Maximum available digits of Tau. "6.2831..."
        /// </summary>
        public static int LengthTau => Tau.Length;

        /// <summary>
        /// Maximum available digits of Tribonaccci. "1.8392..."
        /// </summary>
        public static int LengthTribonacci => Tribonaccci.Length;

        /// <summary>
        /// Maximum available digits of Twelve Root of 2. "1.0594..."
        /// </summary>
        public static int LengthTwelftRootOfTwo => TwelfthRootOfTwo.Length;

        /// <summary>
        /// Maximum available digits of Twin Prime. "0.6601..."
        /// </summary>
        public static int LengthTwinPrime => TwinPrime.Length;

        /// <summary>
        /// Maximum available digits of Universal Parabolic. "2.2955..."
        /// </summary>
        public static int LengthUniversalParabolic => UniversalParabolic.Length;

        /// <summary>
        /// Maximum available digits of Van Der Pauw. "4.5323..."
        /// </summary>
        public static int LengthVanDerPauw => VanDerPauw.Length;

        /// <summary>
        /// Maximum available digits of Viswanath. "1.3519..."
        /// </summary>
        public static int LengthViswanath => Viswanath.Length;

        /// <summary>
        /// Maximum available digits of Wallis. "2.0945..."
        /// </summary>
        public static int LengthWallis => Wallis.Length;

        /// <summary>
        /// Maximum available digits of Weierstrass. "0.4749..."
        /// </summary>
        public static int LengthWeierstrass => Weierstrass.Length;
    }
}