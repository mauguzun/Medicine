import { Language } from "../../../enums/Language";
import { User } from "../User";
import { DrugCategoryDto } from "../DrugCategoryDto";


export class TranslatedDrugsCategory {
  drugCategoryId!: number;
  drugCategory!: DrugCategoryDto;
  title!: string;
  description!: string;
  language!: Language;
  user?: User;
  userId?: number;
  id!: number;
  createdAt?: Date;
}
