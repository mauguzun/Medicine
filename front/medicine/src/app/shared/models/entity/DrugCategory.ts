import { User } from "./User";
import { TranslatedDrugsCategory } from "./translate/TranslatedDrugsCategory";
import { Drug } from "./Drug";


export class DrugCategory {
  drugs: Drug[] = [];
  translations: TranslatedDrugsCategory[] = [];
  user?: User;
  userId?: number;
  id!: number;
  createdAt?: Date;
}
