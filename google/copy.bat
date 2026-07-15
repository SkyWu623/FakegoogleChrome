@echo off
chcp 65001 >nul
:: 設定來源與目標路徑
set "SOURCE=BuildResources"
set "DEST_DEBUG=bin\Debug\net8.0-windows"
set "DEST_RELEASE=bin\Release\net8.0-windows"

echo ============================================
echo   正在開始複製資源檔案...
echo ============================================

:: 1. 檢查來源資料夾是否存在
if not exist "%SOURCE%" (
    echo [錯誤] 找不到來源資料夾: "%SOURCE%"
    echo 請確保此批次檔放在與 "%SOURCE%" 同層的目錄下。
    goto END
)

:: 2. 複製到 Debug 目錄
echo 正在複製至 Debug 目錄...
xcopy "%SOURCE%\*" "%DEST_DEBUG%\" /E /I /Y /D
if %ERRORLEVEL% EQU 0 (
    echo [成功] 已成功複製到 Debug！
) else (
    echo [失敗] 複製到 Debug 時發生錯誤。
)

echo --------------------------------------------

:: 3. 複製到 Release 目錄
echo 正在複製至 Release 目錄...
xcopy "%SOURCE%\*" "%DEST_RELEASE%\" /E /I /Y /D
if %ERRORLEVEL% EQU 0 (
    echo [成功] 已成功複製到 Release！
) else (
    echo [失敗] 複製到 Release 時發生錯誤。
)

:END
echo ============================================
echo   作業結束！
echo ============================================
pause