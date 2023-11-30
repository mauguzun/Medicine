import { Language } from "../../../enums/Language";
import { User } from "../User";
import { ActiveElement } from "../ActiveElement";


export class TranslatedActiveElement {
  activeElement!: ActiveElement;
  activeElementId!: number;
  title?: string;
  description?: string;
  language!: Language;
  user?: User;
  userId?: number;
  id!: number;
  createdAt?: Date;
}
