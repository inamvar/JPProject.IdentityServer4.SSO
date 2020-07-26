import { Injectable } from "@angular/core";
import { TranslateService } from "@ngx-translate/core";

@Injectable({
    providedIn: 'root',
})
export class TranslatorService {

    private defaultLanguage = "fa";

    private availablelangs = [
        { code: "fa", text: "English" },
        { code: "en", text: "English" },
        { code: "pt", text: "Portuguese" },
        { code: "fr", text: "French" },
        { code: "nl", text: "Dutch" },
        { code: "ru", text: "Russian" },
        { code: "zh-cn", text: "Chinese Simplified" },
        { code: "zh-tw", text: "Chinese Traditional" },
        { code: "el", text: "Greek" },
    ];

    constructor(public translate: TranslateService) {

        if (!translate.getDefaultLang())
            translate.setDefaultLang(this.defaultLanguage);

        this.useLanguage(translate.currentLang || this.defaultLanguage);

    }

    useLanguage(lang: string = null) {
        this.translate.use(lang || this.translate.getDefaultLang());
    }

    getAvailableLanguages() {
        return this.availablelangs;
    }

}
