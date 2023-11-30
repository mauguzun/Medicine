import { Language } from "../../../enums/Language";
import { User } from "../User";
import { DosingFrequencyReminder } from "../DosingFrequencyReminder";


export class TranslatedDosingFrequencyReminder {
  title!: string;
  usingDescription!: string;
  dosageRecommendation!: DosingFrequencyReminder;
  dosageRecommendationId!: number;
  language!: Language;
  user?: User;
  userId?: number;
  id!: number;
  createdAt?: Date;
}
