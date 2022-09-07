# WinINet Connection Security
A small example of using WinINet to interrogate open internet handles for negotiated security protocols and ciphers.

Usage:

```C#
IntPtr internetHandle = InternetServices.InternetOpen("Debug", 1, null, null, 0);
internetHandle = InternetServices.InternetOpenUrl(
    internetHandle, @"https://www.google.com/", null, 0, 2147483648, IntPtr.Zero);
SecurityInfo securityInfo = InternetServices.GetSecurityInfo(internetHandle);

// When creating internet handles make sure to free them once they are no longer needed.
InternetServices.InternetCloseHandle(internetHandle);
```

![Locals View](https://github.com/BL1NDX3N0N/WinINet-Connection-Security/blob/main/assets/LocalsView.jpg)

All necessary functions in the Windows Internet API have been wrapped for you and further documentation can be found below:

- https://docs.microsoft.com/en-us/windows/win32/api/wininet/nf-wininet-internetopenw
- https://docs.microsoft.com/en-us/windows/win32/api/wininet/nf-wininet-internetopenurlw
- https://docs.microsoft.com/en-us/windows/win32/api/wininet/nf-wininet-internetclosehandle
- https://docs.microsoft.com/en-us/windows/win32/api/wininet/nf-wininet-internetqueryoptionw
- https://docs.microsoft.com/en-us/windows/win32/wininet/setting-and-retrieving-internet-options
