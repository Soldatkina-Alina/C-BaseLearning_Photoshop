using System;

namespace MyPhotoshop
{
    public delegate Pixel FilterProcess(Pixel original, double[] parameters);

    public interface IFilter
	{
        /// <summary>
        /// ���� ����� ������ ���������� �������� ����������, ������� ���������� � NumericUpDown-��������
        /// ����� �� �������� ������ �������
        /// </summary>
        /// <returns></returns>
  	    ParameterInfo[] GetParameters();
        /// <summary>
        /// ���� ����� ��������� ����������, ������� ���� ������������, � ��������� �������� ���� ����������
        /// ����� ������� parameters � �������� ����� ����� �������, ������������� ������� GetParameters
        /// </summary>
        /// <param name="original"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
		Photo Process(Photo original, double[] parameters);

        Photo ProcessPixel(Photo original, double[] parameters, FilterProcess filterProcess);
    }
}

