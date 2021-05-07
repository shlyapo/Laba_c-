#pragma once

#ifdef LIBRARY_EXPORTS
#define LIBRARY_API __declspec(dllexport)
#else
#define LIBRARY_API __declspec(dllimport)
#endif

extern "C"
{
	LIBRARY_API double MillimetersToCentimeters(double number);
	LIBRARY_API double MillimetersToDecimeters(double number);
	LIBRARY_API double MillimetersToMeters(double number);
	LIBRARY_API double MillimetersToKilometers(double number);

	LIBRARY_API double CentimetersToMillimeters(double number);
	LIBRARY_API double CentimetersToDecimeters(double number);
	LIBRARY_API double CentimetersToMeters(double number);
	LIBRARY_API double CentimetersToKilometers(double number);

	LIBRARY_API double DecimetersToMillimeters(double number);
	LIBRARY_API double DecimetersToCentimeters(double number);
	LIBRARY_API double DecimetersToMeters(double number);
	LIBRARY_API double DecimetersToKilometers(double number);

	LIBRARY_API double MetersToMillimeters(double number);
	LIBRARY_API double MetersToCentimeters(double number);
	LIBRARY_API double MetersToDecimeters(double number);
	LIBRARY_API double MetersToKilometers(double number);

	LIBRARY_API double KilometersToMillimeters(double number);
	LIBRARY_API double KilometersToCentimeters(double number);
	LIBRARY_API double KilometersToDecimeters(double number);
	LIBRARY_API double KilometersToMeters(double number);
}