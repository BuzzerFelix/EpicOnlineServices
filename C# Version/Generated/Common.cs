// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices
{
	public static class Common
	{
		/// <summary>
		/// An invalid notification ID
		/// </summary>
		public const ulong InvalidNotificationid = ((ulong)0);

		/// <summary>
		/// The most recent version of the <see cref="PageQuery" /> structs.
		/// </summary>
		public const int PagequeryApiLatest = 1;

		/// <summary>
		/// The default MaxCount used for a <see cref="PageQuery" /> when the API allows the <see cref="PageQuery" /> to be omitted.
		/// </summary>
		public const int PagequeryMaxcountDefault = 10;

		/// <summary>
		/// The maximum MaxCount used for a <see cref="PageQuery" />.
		/// </summary>
		public const int PagequeryMaxcountMaximum = 100;

		/// <summary>
		/// DEPRECATED! Use <see cref="PagequeryApiLatest" /> instead.
		/// </summary>
		public const int PaginationApiLatest = PagequeryApiLatest;

		/// <summary>
		/// Returns whether a result is to be considered the final result, or false if the callback that returned this result
		/// will be called again either after some time or from another action.
		/// </summary>
		/// <param name="result">The result to check against being a final result for an operation</param>
		/// <returns>
		/// True if this result means the operation is complete, false otherwise
		/// </returns>
		public static bool IsOperationComplete(Result result)
		{
			var funcResult = Bindings.EOS_EResult_IsOperationComplete(result);

			bool funcResultReturn;
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Returns a string representation of an <see cref="Result" />.
		/// The return value is never null.
		/// The return value must not be freed.
		/// 
		/// Example: <see cref="ToString" />(<see cref="Result.Success" />) returns "<see cref="Result.Success" />"
		/// </summary>
		public static string ToString(Result result)
		{
			var funcResult = Bindings.EOS_EResult_ToString(result);

			string funcResultReturn;
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Encode a byte array into hex encoded string
		/// </summary>
		/// <returns>
		/// An <see cref="Result" /> that indicates whether the byte array was converted and copied into the OutBuffer.
		/// <see cref="Result.Success" /> if the encoding was successful and passed out in OutBuffer
		/// <see cref="Result.InvalidParameters" /> if you pass a null pointer on invalid length for any of the parameters
		/// <see cref="Result.LimitExceeded" /> - The OutBuffer is not large enough to receive the encoding. InOutBufferLength contains the required minimum length to perform the operation successfully.
		/// </returns>
		public static Result ToString(byte[] byteArray, out string outBuffer)
		{
			var byteArrayAddress = System.IntPtr.Zero;
			uint length;
			Helper.TryMarshalSet(ref byteArrayAddress, byteArray, out length);

			System.IntPtr outBufferAddress = System.IntPtr.Zero;
			uint inOutBufferLength = 1024;
			Helper.TryMarshalAllocate(ref outBufferAddress, inOutBufferLength);

			var funcResult = Bindings.EOS_ByteArray_ToString(byteArrayAddress, length, outBufferAddress, ref inOutBufferLength);

			Helper.TryMarshalDispose(ref byteArrayAddress);

			Helper.TryMarshalGet(outBufferAddress, out outBuffer);
			Helper.TryMarshalDispose(ref outBufferAddress);

			return funcResult;
		}

		public static string ToString(byte[] byteArray)
		{
			string funcResult;
			ToString(byteArray, out funcResult);
			return funcResult;
		}
	}
}