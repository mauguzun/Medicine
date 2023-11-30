import { User } from "./User";
import { TranslatedDrugs } from "./translate/TranslatedDrugs";
import { ActiveElement } from "./ActiveElement";
import { SimilarDrugs } from "./SimilarDrugs";
import { DrugCategory } from "./DrugCategory";


export class Drug {
  title?: string;
  oneUnitSizeInGramm!: number;
  drugCategories: DrugCategory[] = [];
  similarDrugs!: SimilarDrugs;
  similarDrugsId!: number;
  activeElements: ActiveElement[] = [];
  translations: TranslatedDrugs[] = [];
  user?: User;
  userId?: number;
  id!: number;
  createdAt?: Date;
}
