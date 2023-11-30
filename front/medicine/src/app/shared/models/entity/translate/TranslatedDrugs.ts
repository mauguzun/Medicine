import { Language } from "../../../enums/Language";
import { User } from "../User";
import { Drug } from "../Drug";

export class TranslatedDrugs {
  drugId!: number;
  recomendation?: string;
  drug!: Drug;
  title?: string;
  description?: string;
  language!: Language;
  user?: User;
  userId?: number;
  id!: number;
  createdAt?: Date;
}
