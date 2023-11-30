import { Language } from "../../../enums/Language";

export class TranslatedDrugsResponce {
  recomendation?: string;
  title?: string;
  description?: string;
  language!: Language;
  id!: number;
}
