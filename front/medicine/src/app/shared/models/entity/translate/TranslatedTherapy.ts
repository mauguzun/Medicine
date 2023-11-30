import { Language } from "../../../enums/Language";
import { User } from "../User";
import { Therapy } from "../Therapy";


export class TranslatedTherapy {
  therapyId!: number;
  therapy!: Therapy;
  title?: string;
  description?: string;
  language!: Language;
  user?: User;
  userId?: number;
  id!: number;
  createdAt?: Date;
}
