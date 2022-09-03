# googlesigninMVC
Google Sign in Sample


``` html5
<script src="https://accounts.google.com/gsi/client" async defer></script>
<div id="g_id_onload"
         data-client_id="{用戶端編號}"
         data-login_uri="{登入成功後轉倒頁面}">   
    </div>
    <div class="g_id_signin"
         data-type="standard"
         data-size="large"
         data-theme="outline"
         data-text="sign_in_with"
         data-shape="rectangular"
         data-locale="zh-TW"
         data-logo_alignment="left">
    </div>
```

```
安裝nuget  Microsoft.IdentityModel.JsonWebTokens 
C#後端 LoginController
```

#搜尋整個方案 google sign in 