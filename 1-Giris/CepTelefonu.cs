using System;
namespace _1_Giris
{
	public enum Marka
	{
		Samsung=1,
		Xiaomi,
		Apple,
		Huawei,
		Oppo,
		Poco,
		Honor,
		Realme
	}

	public enum DahiliHafiza

	{
		_16Gb=1,
		_32Gb,
		_64Gb,
		_128Gb,
		_256Gb,
		_512Gb,
		_1Tb

	}

    public enum RamKapasitesi
    {
		_8Gb = 1,
        _16Gb,
        _32Gb,
        _64Gb,
        _128Gb,
        _256Gb,
        _512Gb,
        _1Tb

    }

    public enum EkranBoyutu
    {
        _6_1_inch = 1,
        _6_2_inch,
        _6_3_inch,
        _6_4_inch,
        _6_6_inch,
        _6_7_inch,
        _6_8_inch,
        _6_9_inch

    }

    public class CepTelefonu
	{
		public Marka Marka { get; set; }
		public string Model { get; set; }
		public DahiliHafiza DahiliHafiza { get; set; }
		public RamKapasitesi RamKapasitesi { get; set; }
		public EkranBoyutu EkranBoyutu { get; set; }
	}
}

