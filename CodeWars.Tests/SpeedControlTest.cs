﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests;

internal class SpeedControlTest
{
	static IEnumerable<TestCaseData> testCases
	{
		get
		{
			yield return new TestCaseData(20, new[] { 0.0, 0.23, 0.46, 0.69, 0.92, 1.15, 1.38, 1.61 }).Returns(41);
			yield return new TestCaseData(12, new[] { 0.0, 0.11, 0.22, 0.33, 0.44, 0.65, 1.08, 1.26, 1.68, 1.89, 2.1, 2.31, 2.52, 3.25 }).Returns(219);
			yield return new TestCaseData(20, new[] { 0.0, 0.18, 0.36, 0.54, 0.72, 1.05, 1.26, 1.47, 1.92, 2.16, 2.4, 2.64, 2.88, 3.12, 3.36, 3.6, 3.84 }).Returns(80);
			yield return new TestCaseData(14, new[] { 0.0, 0.01, 0.36, 0.6, 0.84, 1.05, 1.26, 1.47, 1.68, 1.89, 2.1, 2.31, 2.52, 2.73, 2.94, 3.15 }).Returns(90);
			yield return new TestCaseData(17, new[] { 0.0, 0.02, 0.36, 0.54, 0.72, 0.9, 1.08, 1.26, 1.44, 1.62, 1.8 }).Returns(72);
			yield return new TestCaseData(12, new[] { 0.0, 0.24, 0.48, 0.72, 0.96, 1.2, 1.44, 1.68, 1.92, 2.16, 2.4 }).Returns(72);
			yield return new TestCaseData(17, new[] { 0.0, 0.02, 0.44, 0.66, 0.88, 1.1, 1.32, 1.54, 1.76 }).Returns(88);
			yield return new TestCaseData(16, new[] { 0.0, 0.2, 0.4, 0.6, 0.8, 1.0, 1.32, 1.54, 1.76, 1.98, 2.2, 2.42, 2.76, 2.99, 3.22, 3.45 }).Returns(76);
			yield return new TestCaseData(17, new[] { 0.0, 0.01, 0.36, 0.75, 1.0, 1.25, 1.5, 1.75, 2.0, 2.25, 2.5, 2.75, 3.0, 3.25, 3.5, 3.75, 4.0, 4.25, 4.5, 4.75 }).Returns(82);
			yield return new TestCaseData(19, new[] { 0.0, 0.2, 0.4, 0.69, 0.92, 1.15, 1.38, 1.61, 1.92, 2.16, 2.4, 2.64, 2.88, 3.12, 3.36 }).Returns(58);
			yield return new TestCaseData(19, new double[] { }).Returns(0);
			yield return new TestCaseData(19, new[] { 0.0 }).Returns(0);
		}
	}

	[Test, TestCaseSource(nameof(testCases))]
	public static int Test(int s, double[] array) => SpeedControl.Gps(s, array);
}
