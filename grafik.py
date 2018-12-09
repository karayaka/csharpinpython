import xml.etree.ElementTree as ET 
import os
import numpy as np
import matplotlib.pyplot as plt


base_path=os.path.dirname(os.path.realpath(__file__))
xml_file=os.path.join(base_path,"veri.xml")
obj= ET.parse(xml_file)

root=obj.getroot()
liste =  list()
sayi= list()
for c in root:
    print(c.tag,c.text)
    liste.append(c.tag)
    sayi.append(c.text)
y_post=np.arange(len(liste))



plt.bar(y_post, sayi,align='center',alpha=0.5)
plt.xticks(y_post,liste)



plt.show()

  
    
    
