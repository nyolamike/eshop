using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eshop.Models
{
    public class Countries
    {
        #region data
        private static Dictionary<string, Country> _list = new Dictionary<string, Country>() {
            {"afghanistan", new Country("afghanistan","afn","93","afghan","", new List<string> (){ "kabul", "kandahar", "herat", "ghazni", "farah", "khost" }) },
            {"albania", new Country("albania","alb","355","albanian","", new List<string> (){ "tirana", "durres", "vlore", "elbasan", "shkoder", "fier" }) },
            {"algeria", new Country("algeria","dza","213","algerian","", new List<string> (){ "algiers", "constantine", "oran", "annaba", "tlemcen", "batna" }) },
            {"american samoa", new Country("american samoa","asm","1-684","american samoan","", new List<string> (){ "pago pago ", "tafuna", "leone", "faleniu", "fagatogo ", "vaitogi " }) },
            {"andorra", new Country("andorra","and","376","andorran","", new List<string> (){ "canillo", "l'aldosa", "l'armiana", "bordes d'envalira", "la massana", "la massana" }) },
            {"angola", new Country("angola","ago","244","angolan","", new List<string> (){ "luanda", "n'dalatando", "huambo", "lobito", "benguela", "kuito" }) },
            {"anguilla", new Country("anguilla","aia","1-264","anguillan","", new List<string> (){ "the valley , the valley", "blowing point village , blowing point", "sandy ground village , sandy ground" }) },
            {"antarctica", new Country("antarctica","ata","672","antiguan barbudian","", new List<string> (){ "mcmurdo station" }) },
            {"antigua and barbuda", new Country("antigua and barbuda","atg","1-268","antiguan barbudian","", new List<string> (){ "saint john's", "all saints", "liberta", "potter's village", "bolans" }) },
            {"argentina", new Country("argentina","arg","54","argentinian","", new List<string> (){ "buenos aires", "c rdoba", "rosario", "mendoza", "la plata", "tucum n" }) },
            {"armenia", new Country("armenia","arm","374","armenian","", new List<string> (){ "aparan municipality", "ashtarak municipality", "talin municipality" }) },
            {"aruba", new Country("aruba","abw","297","aruban","", new List<string> (){ "noord", "oranjestad", "eagle beach", "paradera", "san nicolaas", "santa cruz" }) },
            {"australia", new Country("australia","aus","61","australian","", new List<string> (){ "sydney", "melbourne", "brisbane", "perth", "adelaide" }) },
            {"austria", new Country("austria","aut","43","austrian","", new List<string> (){ "vienna", "graz", "linz", "salzburg", "innsbruck", "klagenfurt" }) },
            {"azerbaijan", new Country("azerbaijan","aze","994","azerbaijani","", new List<string> (){ "baku", "sumqayit", "ganja", "mingachevir", "lankaran", "shirvan" }) },
            {"bahamas", new Country("bahamas","bhs","1 242","bahamian","", new List<string> (){ "nassau", "freeport", "west end", "coopers town", "marsh harbour", "freetown" }) },
            {"bahrain", new Country("bahrain","bhr","973","bahraini","", new List<string> (){ "manama", "riffa", "muharraq", "hamad town", "a'ali", "isa town" }) },
            {"bangladesh", new Country("bangladesh","bgd","880","bangladeshi","", new List<string> (){ "bogra", "jessore", "cox's bazar", "brahmanbaria", "dinajpur", "nawabganj" }) },
            {"barbados", new Country("barbados","brb","1 246","barbadian","", new List<string> (){ "christ church", "saint andrew", "saint george", "saint james", "saint john", "saint joseph" }) },
            {"belarus", new Country("belarus","blr","375","belarusian ","", new List<string> (){ "minsk", "barysaw", "salihorsk", "maladzyechna", "zhodzina", "slutsk" }) },
            {"belgium", new Country("belgium","bel","32","belgian","", new List<string> (){ "aalst", "aarschot", "andenne", "antoing", "antwerp", "arlon" }) },
            {"belize", new Country("belize","blz","501","belizean","", new List<string> (){ "belize city", "san ignacio", "corozal town", "orange walk town", "dangriga", "punta gorda" }) },
            {"benin", new Country("benin","ben","229","beninese","", new List<string> (){ "cotonou", "porto-novo", "parakou", "djougou", "bohicon", "kandi" }) },
            {"bermuda", new Country("bermuda","bmu","1 441","bermuda ","", new List<string> (){ "saint george", "hamilton city", "stovel bay, pembroke", "cross bay, southampton" }) },
            {"bhutan", new Country("bhutan","btn","975","bhutanese ","", new List<string> (){ "thimphu", "phuntsholing", "samdrup jongkhar", "punakha", "geylegphug", "paro" }) },
            {"bolivia", new Country("bolivia","bol","591","bolivian","", new List<string> (){ "santa cruz de la sierra", "el alto", "la paz", "cochabamba", "oruro", "sucre" }) },
            {"bosnia and herzegovina", new Country("bosnia and herzegovina","bih","387","bosnian","", new List<string> (){ "sarajevo", "banja luka", "tuzla", "zenica", "bijeljina", "mostar" }) },
            {"botswana", new Country("botswana","bwa","267","batswana ","", new List<string> (){ "gaborone", "francistown", "lobatse", "selibe phikwe", "jwaneng", "maun", "molepolole" }) },
            {"brazil", new Country("brazil","bra","55","brazilian","", new List<string> (){ "s o paulo", "rio de janeiro", "bras lia", "salvador", "fortaleza", "belo horizonte" }) },
            {"brunei darussalam", new Country("brunei darussalam","brn","673","bruneian ","", new List<string> (){ "bandar seri begawan", "kuala belait", "seria", "tutong" }) },
            {"bulgaria", new Country("bulgaria","bgr","359","bulgarian","", new List<string> (){ "sofia", "plovdiv", "varna", "burgas", "ruse", "stara zagora" }) },
            {"burkina faso", new Country("burkina faso","bfa","226","burkinese","", new List<string> (){ "ouagadougou", "bobo dioulasso", "banfora", "koudougou", "ouahigouya", "kaya" }) },
            {"burundi", new Country("burundi","bdi","257","burundian","", new List<string> (){ "bujumbura", "gitega", "muyinga", "ngozi", "ruyigi", "kayanza" }) },
            {"cambodia", new Country("cambodia","khm","855","cambodian","", new List<string> (){ "phnom penh", "ta khmau", "battambang", "serei saophoan", "siem reap", "kampong cham" }) },
            {"cameroon", new Country("cameroon","cmr","237","cameroonian","", new List<string> (){ "douala", "yaound ", "bamenda", "bafoussam", "garoua", "maroua" }) },
            {"canada", new Country("canada","can","1","canadian","", new List<string> (){ "ottawa", "edmonton", "victoria", "winnipeg", "fredericton", "st. john's" }) },
            {"cape verdean", new Country("cape verdean","cpv","238","cape verdean","", new List<string> (){ "algiers", "constantine", "oran", "annaba", "tlemcen", "batna" }) },
            {"cayman islands", new Country("cayman islands","cym","1 345","caymanian","", new List<string> (){ "praia", "mindelo", "assomada", "porto novo", "s o filipe" }) },
            {"central african republic", new Country("central african republic","caf","236","central africans","", new List<string> (){ "bangui", "bimbo", "berb rati", "carnot", "bambari", "bouar" }) },
            {"chad", new Country("chad","tcd","235","chadian","", new List<string> (){ "n'djamena", "moundou", "sarh", "ab ch ", "k lo", "koumra" }) },
            {"chile", new Country("chile","chl","56","chilean","", new List<string> (){ "arica", "iquique", "alto hospicio", "pozo almonte", "antofagasta", "calama" }) },
            {"china", new Country("china","chn","86","chinese","", new List<string> (){ "hong kong", "macau", "beijing", "chongqing", "shanghai", "tianjin" }) },
            {"colombia", new Country("colombia","col","57","colombian","", new List<string> (){ "bogot ", "medell n", "cali", "barranquilla", "cartagena", "c cuta" }) },
            {"comoros", new Country("comoros","com","269","comorian","", new List<string> (){ "anjouan", "grande comore", "moh li" }) },
            {"congo, the democratic republic of the", new Country("congo, the democratic republic of the","cod","242","congolese","", new List<string> (){ "aba", "aketi", "ango", "aru", "bafwasende", "bagata" }) },
            {"congo", new Country("congo","cog","243","congolese","", new List<string> (){ "brazzaville", "pointe-noire", "dolisie", "nkayi", "kindamba", "impfondo" }) },
            {"costa rica", new Country("costa rica","cri","506","costa rican","", new List<string> (){ "san jos ", "escaz ", "desamparados", "puriscal", "tarraz ", "aserr " }) },
            {"c te d'ivoire", new Country("c te d'ivoire","civ","225","ivoirian","", new List<string> (){ "abidjan", "bouak ", "daloa", "yamoussoukro", " san-p dro", "divo" }) },
            {"croatia", new Country("croatia","hrv","385","croatian","", new List<string> (){ "zagreb", "split", "rijeka", "osijek", "zadar", "velika gorica" }) },
            {"cuba", new Country("cuba","cub","53","cuban","", new List<string> (){ "havana", "santiago de cuba", "camag ey", "holgu n", "guant namo", "santa clara" }) },
            {"cyprus", new Country("cyprus","cpy","357","cypriot","", new List<string> (){ "famagusta", "limassol", "larnaca", "nicosia", "paphos", "kyrenia" }) },
            {"czech republic", new Country("czech republic","cze","420","czech","", new List<string> (){ " brno", "ostrava", "plzen", "olomouc", " st nad labem", "cesk budejovice" }) },
            {"denmark", new Country("denmark","dnk","45","danish","", new List<string> (){ "copenhagen", "aarhus", "odense", "aalborg", "esbjerg", "randers" }) },
            {"djibouti", new Country("djibouti","dj","253","djiboutian","", new List<string> (){ "djibouti city", "ali sabieh", "tadjourah", "obock", "dikhil", "arta" }) },
            {"dominica", new Country("dominica","dma","1 767","dominican","", new List<string> (){ "roseau", "portsmouth", "marigot" }) },
            {"dominican republic", new Country("dominican republic","dom","1 809","dominican","", new List<string> (){ "santo domingo", "santiago", "la vega san", "san crist ba san", "san pedro de macor s" }) },
            {"east timor", new Country("east timor","tls","670","timorese ","", new List<string> (){ "dili", "pante makasar", "suai", "baucau", "liquica ermera", "manatuto" }) },
            {"ecuador", new Country("ecuador","ecu","593","ecuadorean","", new List<string> (){ "guayaquil", "quito", "cuenca", "santo domingo", "machala", "manta" }) },
            {"egypt", new Country("egypt","egy","20","egyptian","", new List<string> (){ "cairo", "alexandria", "giza", "shubra el kheima", "port said", "suez" }) },
            {"england", new Country("england","eng","44","english","", new List<string> (){ "manchester", "london", "liverpool", "newcastle", "sunderland", "birmingham" }) },
            {"el salvador", new Country("el salvador","slv","503","salvadorean","", new List<string> (){ "acajutla", "apopa", "antiguo cuscatl n", "ciudad delgado", "cuscatancingo", "llopango" }) },
            {"equatorial guinea", new Country("equatorial guinea","gnq","240","bermuda ","", new List<string> (){ "bata", "malabo", "ebebiy n", "aconibe", "a isoc", "luba" }) },
            {"eritrea", new Country("eritrea","eri","291","eritrean ","", new List<string> (){ "asmara", "keren", "teseney", "mendefera", "agordat", "assab" }) },
            {"estonia", new Country("estonia","est","372","estonian","", new List<string> (){ "tallinn", "tartu", "narva", "p rnu", "kohtla-j rve", "viljandi" }) },
            {"ethiopia", new Country("ethiopia","rth","251","ethiopian","", new List<string> (){ "addis ababa", "gondar", "mek'ele", "adama", "hawassa", "bahir dar" }) },
            {"fiji", new Country("fiji","fji","679","fijian","", new List<string> (){ "lautoka", "suva", "ba", "labasa", "lami", "levuka" }) },
            {"finland", new Country("finland","fin","358","finnish","", new List<string> (){ "akaa", "alaj rvi", "alavus", "espoo", "forssa", "haapaj rvi" }) },
            {"france", new Country("france","fra","33","french","", new List<string> (){ "paris", "marseille", "lyon", "toulouse", "nice", "nantes" }) },
            {"french polynesia", new Country("french polynesia","pyf","689","french","", new List<string> (){ "faa'a", "papeete", "punaauia", "pirae", "moorea-maiao", "mahina" }) },
            {"gabon", new Country("gabon","gab","241","gabonese","", new List<string> (){ "libreville", "port-gentil", "masuku (franceville)", "oyem", "moanda", "mouila" }) },
            {"gambia", new Country("gambia","gmb","220","gambian","", new List<string> (){ "banjul", "serekunda", "banjul", "bansang", "basse santa su", "brikama" }) },
            {"georgia", new Country("georgia","geo","995","georgian","", new List<string> (){ "tbilisi", "batumi", "kutaisi", "rustavi", "gori", "zugdidi" }) },
            {"germany", new Country("germany","deu","49","german","", new List<string> (){ "berlin", "hamburg", "munich", "cologne", "stuttgart", "d sseldorf" }) },
            {"ghana", new Country("ghana","gha","233","ghanaian","", new List<string> (){ "accra", "kumasi", "sekondi-takoradi", "ashiaman", "sunyani", "tamale" }) },
            {"greece", new Country("greece","grc","30","greek","", new List<string> (){ "athens", "thessalonik", "patras", "heraklion", "larissa", "volos" }) },
            {"greenland", new Country("greenland","grl","299","antiguan barbudian","", new List<string> (){ "nuuk", "sisimiut", "ilulissat", "aasiaat", "qaqortoq", "maniitsoq" }) },
            {"grenada", new Country("grenada","grd","1 473","grenadian","", new List<string> (){ "sait georges", "grenada", "sauteurs", "gouyave", "grenville" }) },
            {"guam", new Country("guam","gum","1 671","guamanian","", new List<string> (){ "hagatna", "sinajana", "mongmong", "hagatna heights", "chalan pago" }) },
            {"guatemala", new Country("guatemala","gtm","502","guatemalan","", new List<string> (){ "guatemala city", "mixco", "villa nueva", "quetzaltenango", "san miguel petapa", "escuintla" }) },
            {"guinea-bissau", new Country("guinea-bissau","gnb","245","guinean","", new List<string> (){ "bissau", "bafat ", "gab ", "bissor ", "bolama", "cacheu" }) },
            {"guinea", new Country("guinea","gin","224","guinean","", new List<string> (){ "conakry", "nz r kor ", "kindia", "bok ", "kankan", "kissidougou" }) },
            {"guyana", new Country("guyana","guy","592","guyanese","", new List<string> (){ "georgetown", "berbice" }) },
            {"haiti", new Country("haiti","hti","509","haitian","", new List<string> (){ "port-au-prince", "cap-ha tien" }) },
            {"honduras", new Country("honduras","hnd","504","honduran","", new List<string> (){ "tegucigalpa", "san pedro sula", "choloma", "la ceiba", "el progreso", "choluteca" }) },
            {"hong kong", new Country("hong kong","hkg","852","chinese ","", new List<string> (){ "tsuen wan", "sha tin", "tuen mun new town", "tai po", "yuen long", "fanling-sheung shui" }) },
            {"hungary", new Country("hungary","hun","36","hungarian ","", new List<string> (){ "budapest", "debrecen", "szeged", "miskolc", "p cs", "gyor" }) },
            {"iceland", new Country("iceland","isl","354","icelandic","", new List<string> (){ "kabul", "kandahar", "herat", "ghazni", "farah", "khost" }) },
            {"india", new Country("india","ind","91","indian","", new List<string> (){ "tirana", "durres", "vlore", "elbasan", "shkoder", "fier" }) },
            {"indonesia", new Country("indonesia","idn","62","indonesian","", new List<string> (){ "algiers", "constantine", "oran", "annaba", "tlemcen", "batna" }) },
            {"iran", new Country("iran","irn","98","iranian","", new List<string> (){ "ardabil", "karaj", "fardis", "kamal shahr", "nazarabad", "mohammadshahr" }) },
            {"iraq", new Country("iraq","irq","964","iraqi","", new List<string> (){ "al diwaniyah", "al hillah", "baghdad", "baiji", "balad", "basra" }) },
            {"ireland", new Country("ireland","irl","353","irish","", new List<string> (){ "dublin", "cork", "limerick", "waterford" }) },
            {"israel", new Country("israel","isr","972","israelis","", new List<string> (){ "haifa", "netanya", "ashdod", "jerusalem", "tel aviv-jaffa", "rishon" }) },
            {"italy", new Country("italy","ita","39","italian","", new List<string> (){ "rome", "milan", "naples", "palermo", "genoa", "bologna" }) },
            {"ivory coast", new Country("ivory coast","civ","225","ivorian","", new List<string> (){ "abidjan", "bouak ", "daloa", "yamoussoukro", " san-p dro", "divo" }) },
            {"jamaica", new Country("jamaica","jam","1 876","jamaican","", new List<string> (){ "kingston", "montego bay" }) },
            {"japan", new Country("japan","jpn","81","japanese","", new List<string> (){ "tokyo ", "nagoya", "toyohashi", "ichinomiya", "seto", "handa" }) },
            {"jersey", new Country("jersey","jey","44 1534","british","", new List<string> (){ "saint helier", "st aubin", "st .john", "gorey" }) },
            {"jordan", new Country("jordan","jor","962","jordanian","", new List<string> (){ "amman", "zarqa", "irbid", "russeifa", "al-quwaysimah" }) },
            {"kazakhstan", new Country("kazakhstan","kaz","7","kazakh","", new List<string> (){ "almaty", "shymkent", "karaganda", "pavlodar", "semey", "oskemen" }) },
            {"kenya", new Country("kenya","ken","254","kenyan","", new List<string> (){ "nairobi", "mombasa", "kisumu", "nakuru", "eldoret ", "malindi" }) },
            {"kosovo", new Country("kosovo","xkx","383","kosovan","", new List<string> (){ "pristina", "prizren", "gjilan", "peja", "mitrovica" }) },
            {"kuwait", new Country("kuwait","kwt","965","kuwaiti","", new List<string> (){ "kuwait city", "sharq", "jibla", "dasma", "da'iya" }) },
            {"kyrgyzstan)", new Country("kyrgyzstan)","kgz","996","kazakh","", new List<string> (){ "bishkek", "osh", "jalal-abad", "karakol", "farah", "uzgen" }) },
            {"laos", new Country("laos","lao","856","laotian","", new List<string> (){ "vientiane", "pakse", "sekong", "avannakhet", "muang xay" }) },
            {"latvia", new Country("latvia","lva","371","laotian","", new List<string> (){ "riga", "daugavpils", "liepaja", "jelgava", "jurmala", "rezekne" }) },
            {"lebanon", new Country("lebanon","lbn","961","lebanese","", new List<string> (){ "beirut", "tripoli", "jounieh", "sidon", "zahle" }) },
            {"lesotho", new Country("lesotho","lso","266","basotho","", new List<string> (){ "maseru", "teyateyaneng", "mafeteng", "hlotse", "mohale's hoek", "maputsoe" }) },
            {"liberia", new Country("liberia","lbr","231","liberian","", new List<string> (){ "monrovia", "ganta", "buchanan", "gbarnga", "kakata", "voinjama" }) },
            {"libya", new Country("libya","lby","218","libyan","", new List<string> (){ "tripoli", "sabratha", "misurata", "derna", "tobruk", "sirte" }) },
            {"lithuania", new Country("lithuania","ltu","370","lithuanian","", new List<string> (){ "vilnius", "kaunas", "klaipeda", " iauliai", "paneve ys" }) },
            {"luxembourg", new Country("luxembourg","lux","352","luxembourger","", new List<string> (){ "diekirch", "differdange", "dudelange" }) },
            {"macedonia", new Country("macedonia","mkd","389","macedonian","", new List<string> (){ "tirana", "durres", "vlore", "elbasan", "shkoder", "fier" }) },
            {"madagascar", new Country("madagascar","mdg","261","madagascan","", new List<string> (){ "antananarivo", "toamasina", "antsirabe", "mahajanga", "fianarantsoa", "toliara" }) },
            {"malawi", new Country("malawi","mwi","265","malawian","", new List<string> (){ "lilongwe", "mzuzu", "karonga", "chilumba", "zomba", "monkey bay" }) },
            {"malaysia", new Country("malaysia","mys","60","malaysian","", new List<string> (){ "george town", "kuala lumpur", "ipoh", "kuching", "johor bahru", "kota kinabalu" }) },
            {"maldives", new Country("maldives","mdv","960","maldivian","", new List<string> (){ "mal ", "dhidhdhoo", "fuvahmulah", "manadhoo" }) },
            {"mali", new Country("mali","mli","223","malian","", new List<string> (){ "bamako", "sikasso", "s gou", "koutiala", "s gou", "kayes" }) },
            {"malta", new Country("malta","mlt","356","maltese","", new List<string> (){ "birgu", "bormla", "mdina", "qormi", "rabat", "senglea" }) },
            {"marshall islands", new Country("marshall islands","mhl","692","micronesian","", new List<string> (){ "ajeltake", "delap-uliga-djarrit", "ebeye", "laura", "rairok" }) },
            {"mauritania", new Country("mauritania","mrt","222","mauritanian","", new List<string> (){ "nouakchott", "nouadhibou", "rosso", "adel bagrou", "bogh " }) },
            {"mauritius", new Country("mauritius","mus","230","mauritian","", new List<string> (){ "port louis", "beau bassin-rose hill", "curepipe", "quatre bornes", "vacoas-phoenix" }) },
            {"mexico", new Country("mexico","mex","52","mexican","", new List<string> (){ "mexico city", "ecatepec", "guadalajara", "puebla", "ju rez", "tijuana" }) },
            {"moldova", new Country("moldova","mda","373","moldovan","", new List<string> (){ "chi?inau", "bal?i", "tiraspol", "bender (tighina)", "r bni?a" }) },
            {"monaco", new Country("monaco","mco","377","monacan","", new List<string> (){ "fontvieille", "monte carlo", "saint roman", "saint michel" }) },
            {"mongolia", new Country("mongolia","mng","976","mongolian","", new List<string> (){ "erdenet", "darkhan", "choibalsan", "m r n", "nalaikh", "bayankhongor" }) },
            {"montenegro", new Country("montenegro","mne","382","montenegrin","", new List<string> (){ "podgorica", "nik ic", "herceg novi", "pljevlja", "bar", "bijelo polje" }) },
            {"morocco", new Country("morocco","mar","212","moroccan","", new List<string> (){ "casablanca", "fez", "tangier", "marrakesh", "sal ", "meknes" }) },
            {"mozambique", new Country("mozambique","moz","258","mozambican","", new List<string> (){ "maputo", "manica", "dondo", "catandica", "angoche", "bilene" }) },
            {"namibia", new Country("namibia","nam","264","namibian","", new List<string> (){ "windhoek", "walvis bay", "swakopmund", "henties bay", "omaruru", "otjiwarongo" }) },
            {"nepal", new Country("nepal","npl","977","nepalese","", new List<string> (){ "kathmandu", "pokhara lekhnath", "lalitpur", "bharatpur", "birgunj", "biratnagar" }) },
            {"netherlands", new Country("netherlands","nld","31","dutch","", new List<string> (){ "kralendijk", "the bottom", "alphen aan den rijn", "alphen-chaam", "ameland", "amersfoort" }) },
            {"netherlands antilles", new Country("netherlands antilles","ant","599","dutch","", new List<string> (){ "aruba", "bonaire", "sint eustatius", "cura ao", "saba", "sint eustatius" }) },
            {"new caledonia", new Country("new caledonia","ncl","687"," new caledonian","", new List<string> (){ "noum a", "le mont-dore", "dumb a", "pa ta", "lifou", "mar " }) },
            {"new zealand", new Country("new zealand","nzl","64","new zealand butter","", new List<string> (){ "auckland", "wellington", "hamilton", "tauranga", "napier", "dunedin" }) },
            {"niger", new Country("niger","ner","227","nigerien","", new List<string> (){ "agadez", "zinder", "marad", "diffa", "dosso", "gaya" }) },
            {"nigeria", new Country("nigeria","nga","234","nigerian","", new List<string> (){ "lagos", "abuja", "kano, kano state", "port harcourt", "ibadan, oyo state", "benin city" }) },
            {"north korea", new Country("north korea","prk","850","north korean","", new List<string> (){ "hamhung", "sinuiju", "tanchon", "chongjin", "nampo", "kaesong" }) },
            {"norway", new Country("norway","nor","47","norwegian","", new List<string> (){ "oslo", "bergen", "trondheim", "stavanger", "kristiansand", "troms " }) },
            {"oman", new Country("oman","omn","968","omani","", new List<string> (){ "muscat", "as sib", "barka", "khasab", "salalah" }) },
            {"pakistan", new Country("pakistan","pak","92","pakistani","", new List<string> (){ "lahore", "faisalabad", "rawalpindi", "gujranwala", "bahawalpur", "sialkot" }) },
            {"palestine", new Country("palestine","pse","970","palestinian","", new List<string> (){ "gaza strip", "hebron", "nablus", "hebron (al-khalil)", "jenin", "ramallah" }) },
            {"panama", new Country("panama","pan","507","panamanian","", new List<string> (){ "panama city", "col n city", "david", "la chorrera", "santiago", "penonom " }) },
            {"papua new guinea", new Country("papua new guinea","png","675","guinean","", new List<string> (){ " lae", "mount hagen", "port moresby", "alotau", "ambunti" }) },
            {"paraguay", new Country("paraguay","pry","595","paraguayan","", new List<string> (){ "alberdi", "asunci n", "atyr ", "ayolas", "caacup ", "caazap " }) },
            {"peru", new Country("peru","per","51","peruvian","", new List<string> (){ "lima", "arequipa", "trujillo", "chiclayo", "huancayo", "piura" }) },
            {"philippines", new Country("philippines","phl","63","philippine","", new List<string> (){ "quezon city", "palayan", "manila", "san juan", "san pablo" }) },
            {"poland", new Country("poland","pol","48","polish","", new List<string> (){ "krak w", "gdansk", "poznan", "wroclaw", "l dz", "warsaw" }) },
            {"portugal", new Country("portugal","prt","351","portuguese","", new List<string> (){ "lisbon", "porto", "lamego", " vora", "braga", "coimbra" }) },
            {"qatar", new Country("qatar","qat","974","qatari","", new List<string> (){ "doha", "dukhan", "al kwaor" }) },
            {"romania", new Country("romania","rou","40","romanian","", new List<string> (){ "bucharest", "cluj-napoca", "timi?oara", "ia?i", "constan?a", "craiova" }) },
            {"russia", new Country("russia","rus","7","russian","", new List<string> (){ " moscow", "saint petersburg", "novosibirsk", "yekaterinburg", "kazan", "chelyabinsk" }) },
            {"rwanda", new Country("rwanda","rwa","250","rwandan","", new List<string> (){ "kigali", "butare", "muhanga", "ruhengeri", "gisenyi", "byumba" }) },
            {"saint lucia", new Country("saint lucia","lca","1-758","st. lucian","", new List<string> (){ "castries", "au tabor", "babonneau", "bocage", "canaries", "choiseul" }) },
            {"samoa", new Country("samoa","wsm","685","samoan ","", new List<string> (){ "apia", "salelologa" }) },
            {"san marino", new Country("san marino","smr","378","sammarinese","", new List<string> (){ "acquaviva", "faetano" }) },
            {"saudi arabia", new Country("saudi arabia","sau","966","saudi arabian","", new List<string> (){ "abha", "al-abwa", "al artaweeiyah", "badr", "baljurashi", "bisha" }) },
            {"senegal", new Country("senegal","sen","221","senegalese","", new List<string> (){ "dakar", "touba", "thi s", "rufisque", "kaolack", "m'bour" }) },
            {"serbia", new Country("serbia","srb","381","serbian","", new List<string> (){ "belgrade", "bor", "cacak", "jagodina", "kikinda", "kraljevo" }) },
            {"seychelles", new Country("seychelles","syc","248","seychellois","", new List<string> (){ "victoria", "grand anse mahe", "beau vallon", "anse boileau", "beau vallon" }) },
            {"sierra leone", new Country("sierra leone","sle","232","sierra leonian","", new List<string> (){ "freetown", "kenema", "bo", "koidu", "makeni" }) },
            {"singapore", new Country("singapore","sgp","65","singaporean","", new List<string> (){ "pulau ujong" }) },
            {"slovakia", new Country("slovakia","svk","421","slovak","", new List<string> (){ "bratislava", "ko ice", "pre ov", " ilina", "bansk bystrica", "nitra" }) },
            {"slovenia", new Country("slovenia","svn","386","slovene","", new List<string> (){ "ljubljana", "maribor", "celje", "kranj", "velenje", "koper" }) },
            {"somalia", new Country("somalia","som","252","somali","", new List<string> (){ "mogadishu", "hargeisa", "kismayo", "baidoa", "dusmareb", "burhakaba" }) },
            {"south africa", new Country("south africa","zaf","27","south african","", new List<string> (){ "pretoria", "johannesburg", "cape town", "east london", "durban", "bloemfontein" }) },
            {"south korea", new Country("south korea","kor","82","south korean","", new List<string> (){ "andong", "ansan", "anseong", "anyang", "busan", "cheongju" }) },
            {"south sudan", new Country("south sudan","ssd","211","south sudanese ","", new List<string> (){ "abyei", "akobo", "aweil", "bentiu (bantiu)", "farah", "cheongju" }) },
            {"spain", new Country("spain","esp","34","spanish","", new List<string> (){ "kabul", "kandahar", "herat", "juba", "gogrial", "kapoeta" }) },
            {"sri lanka", new Country("sri lanka","lka","94","sri lankan","", new List<string> (){ "colombo", "dehiwala- mount lavinia", "moratuwa", "sri jayawardenapura kotte", "negombo", "kalmunai" }) },
            {"sudan", new Country("sudan","sdn","249","sudanese","", new List<string> (){ "khartoum", "omdurman", "khartoum north", "port sudan", "kassala", "el obeid" }) },
            {"swaziland", new Country("swaziland","swz","268","swazi","", new List<string> (){ "manzini", "mbabane", "big bend", "malkerns", "nhlangano", "mhlume" }) },
            {"sweden", new Country("sweden","swe","46","swedish","", new List<string> (){ "stockholm", "gothenburg", "malm " }) },
            {"switzerland", new Country("switzerland","che","41","swiss","", new List<string> (){ "z rich", "geneva", "lugano" }) },
            {"syria", new Country("syria","syr","963","syrian","", new List<string> (){ "aleppo", "hama", "homs", "idlib", "damascus", "latakia" }) },
            {"taiwan", new Country("taiwan","twn","886","taiwanese","", new List<string> (){ "kaohsiung", "new taipei", "taichung", "tainan", "taipei", "taoyuan" }) },
            {"tajikistan", new Country("tajikistan","tjk","992","tadjik","", new List<string> (){ "dushanbe", "khujand", "kulob", "qurghonteppa", "istaravshan", "vahdat" }) },
            {"tanzania", new Country("tanzania","tza","255","tanzanian","", new List<string> (){ "dar es salaam", "mwanza", "arusha", "dodoma", "mbeya", "morogoro" }) },
            {"thailand", new Country("thailand","tha","66","thai","", new List<string> (){ "bangkok", "nonthaburi", "nakhon ratchasima", "chiang mai", "hat yai", " udon thani" }) },
            {"togo", new Country("togo","tgo","228","togolese","", new List<string> (){ "lom ", "sokod ", "kara", "skpalim ", "atakpam ", "bassar" }) },
            {"tonga", new Country("tonga","ton","676","tongan","", new List<string> (){ "fatumanongi", "foa", "fotuha?a", "hakauata" }) },
            {"trinidad and tobago", new Country("trinidad and tobago","tto","1-868","tobagan","", new List<string> (){ "toco", "point lisas", "siparia", "tunapuna", "point fortin", "arima" }) },
            {"tunisia", new Country("tunisia","tun","216","tunisian","", new List<string> (){ "tunis", "sfax", "ettadhamen", "kairouan", "gab s", "bizerte" }) },
            {"turkey", new Country("turkey","tur","90","turkish","", new List<string> (){ "istanbul", "ankara", "izmir", "bursa", "adana", "gaziantep" }) },
            {"tuvalu", new Country("tuvalu","tuv","688","tuvaluan","", new List<string> (){ "alapi", "angafoulua", "asau", "fakai fou", "fangaua", "funafuti" }) },
            {"uganda", new Country("uganda","ug","256","ugandan","", new List<string> (){ "kampala", "gulu", "lira", "mbale", "entebbe", "nansana" }) },
            {"ukraine", new Country("ukraine","ukr","380","ukrainian","", new List<string> (){ "kiev", "kharkiv", "odessa", "dnipro", "donetsk", "zaporizhia" }) },
            {"united arab emirates", new Country("united arab emirates","are","971","emirati","", new List<string> (){ "dubai", "abu dhabi", "sharjah", "al ain", "ajman", "ras al khaimah" }) },
            {"united states of america", new Country("united states of america","usa","1"," american","", new List<string> (){ "california", "alaska", "sitka", "juneau", "wrangell", "anchorage" }) },
            {"uruguay", new Country("uruguay","ury","598","uruguayan","", new List<string> (){ "montevideo", "salto", "ciudad de la costa", "paysand ", "las piedras", "rivera" }) },
            {"uzbekistan", new Country("uzbekistan","uzb","998","uzbek","", new List<string> (){ "isla rat n", "tashkent", "namangan", "samarqand", "bukhara", "nukus" }) },
            {"vanuatu", new Country("vanuatu","vut","678","vanuatuan","", new List<string> (){ "avire", "bunlap", "butmas", "forari", "ipota", "isangel" }) },
            {"venezuela", new Country("venezuela","ven","58","venezuelan","", new List<string> (){ "isla rat n", "la esmeralda", "maroa", "puerto ayacucho", "san carlos de r o negro", "maracaibo" }) },
            {"vietnam", new Country("vietnam","vnm","84","vietnamese","", new List<string> (){ "c?n tho", " n?ng", "h?i ph ng", "h n?i", "h? ch minh city" }) },
            {"wales", new Country("wales","esh","212","welsh","", new List<string> (){ "cardiff", "swansea" }) },
            {"western sahara", new Country("western sahara","esh","212"," western saharan","", new List<string> (){ "laayoun", "ad-dakhla", "smara", "cape bojador", "el marsa", "hawza" }) },
            {"yemen", new Country("yemen","yem","967","yemeni","", new List<string> (){ "sana'a", "ta'izz", "al hudaydah", "aden", "bb", "dhamar" }) },
            {"zambia", new Country("zambia","zmb","260","zambian","", new List<string> (){ "lusaka", "ndola", "kitwe", "kabwe", "chingola", "mufulira" }) },
            {"zimbabwe", new Country("zimbabwe","zwe","263","zimbabwean","", new List<string> (){ "harare", "bulawayo", "chitungwiza", "mutare", "gweru", "kwekwe" }) }
        };
        #endregion

        public static List<string> GetAllNames()
        {
            return Countries._list.Keys.ToList<string>();
        }

        public static bool IsCountryName(string name)
        {
            return Countries._list.ContainsKey(name.ToLower());
        }

        public static Country GetCountry(string name)
        {
            return Countries._list[name.ToLower()];
        }
    }

    public class Country
    {
        public string Name { get; set; }
        public string Flag { get; set; }
        public string Code { get; set; }
        public string ShortName { get; set; }
        public string Nationality { get; set; }
        public List<string> Cities = new List<string>(); 

        public Country(String Name, String ShortName, String Code, String Nationality, String Flag, List<String> Cities)
        {
            this.Nationality = Nationality;
            this.Name = Name;
            this.Flag = Flag;
            this.Code = Code;
            this.ShortName = ShortName;
            this.Cities = Cities;
        }
    }
}
