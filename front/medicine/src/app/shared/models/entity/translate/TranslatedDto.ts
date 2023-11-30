import { Language } from "../../../enums/Language";

export class TranslatedDto {
  title?: string;
  description?: string;
  language: Language = Language.en;
  id: number = 0;
}