library(ggplot2)
library(dplyr)
setwd(dir = "C:/Users/abbas/Downloads/Olympics")
olympics = data.frame(read.csv("Athletes_since_1990.csv"))
regions = data.frame(read.csv("regions.csv"))
gdp = data.frame(read.csv("national-gdp-wb.csv"))
gii = data.frame(read.csv("HDR21-22_Statistical_Annex_GII_Table.csv"))

agg = aggregate(Sex~NOC,
                data = olympics[olympics$Year == 2020 & olympics$Sex == "F",],
                FUN = function(x) sum(x == "F"))
gii = merge(gii, agg, by = "NOC", all.x = TRUE)
gii$Sex[is.na(gii$Sex)] = 0
colnames(gii)[11] = "GPI"

agg = aggregate(Medal~NOC,
                data = olympics[olympics$Year == 2020 & olympics$Sex == "F",],
                FUN = function(x) sum(x == "Gold"))
gii = merge(gii, agg, by = "NOC", all.x = TRUE)
gii$Medal[is.na(gii$Medal)] = 0
colnames(gii)[12] = "Gold.Medal.Count"

agg = aggregate(Medal~NOC,
                data = olympics[olympics$Year == 2020 & olympics$Sex == "F",],
                FUN = function(x) sum(x == "Silver"))
gii = merge(gii, agg, by = "NOC", all.x = TRUE)
gii$Medal[is.na(gii$Medal)] = 0
colnames(gii)[13] = "Silver.Medal.Count"

agg = aggregate(Medal~NOC,
                data = olympics[olympics$Year == 2020 & olympics$Sex == "F",],
                FUN = function(x) sum(x == "Bronze"))
gii = merge(gii, agg, by = "NOC", all.x = TRUE)
gii$Medal[is.na(gii$Medal)] = 0
colnames(gii)[14] = "Bronze.Medal.Count"

gii$HDI.label = cut(gii$HDI.rank,
                    breaks = c(1,
                               66,
                               115,
                               159,
                               191),
                    labels = c("Very High Human Development",
                               "High Human Development",
                               "Medium Human Development",
                               "Low Human Development"))

# Graph of Women Participation vs Gender Inequality
ggplot(data = gii[gii$GPI != 0,]) +
  geom_point(mapping = aes(x = Gender.Inequality.Index.Value,
                           y = GPI,
                           color = HDI.label)) +
  labs(x = "Gender Inequality Index",
       y = "Women Participation In Olympics",
       title = "Relationship Between Women Participation in Olympics and
       Gender Inequality Index in 2021") +
  geom_smooth(mapping = aes(x = Gender.Inequality.Index.Value,
                            y = GPI,
                            color = HDI.label),
              se = FALSE,
              method = "gam",
              formula = y~x) +
  geom_smooth(mapping = aes(x = Gender.Inequality.Index.Value,
                            y = GPI),
              se = FALSE,
              method = "gam",
              formula = y~x)

# Correlation of the above graph
cor(gii[gii$GPI != 0 &
          !is.na(gii$GPI) &
          !is.na(gii$Gender.Inequality.Index.Value),]$GPI,
    gii[gii$GPI != 0 &
          !is.na(gii$GPI) &
          !is.na(gii$Gender.Inequality.Index.Value),]$Gender.Inequality.Index.Value,
    method = "pearson")

# Graph of Gold Medal Count vs Gender Inequality
ggplot(data = gii[gii$Gold.Medal.Count != 0,]) +
  geom_point(mapping = aes(x = Gender.Inequality.Index.Value,
                           y = Gold.Medal.Count,
                           color = HDI.label)) +
  labs(x = "Gender Inequality Index",
       y = "Number of Gold Medals",
       title = "Relationship Between Number of Gold Medals and
       Gender Inequality Index in 2021") +
  geom_smooth(mapping = aes(x = Gender.Inequality.Index.Value,
                            y = Gold.Medal.Count,
                            color = HDI.label),
              se = FALSE,
              method = "gam",
              formula = y~x) +
  geom_smooth(mapping = aes(x = Gender.Inequality.Index.Value,
                            y = Gold.Medal.Count),
              se = FALSE,
              method = "gam",
              formula = y~x)

# Graph of Silver Medal Count vs Gender Inequality
ggplot(data = gii[gii$Silver.Medal.Count != 0,]) +
  geom_point(mapping = aes(x = Gender.Inequality.Index.Value,
                           y = Silver.Medal.Count,
                           color = HDI.label)) +
  labs(x = "Gender Inequality Index",
       y = "Number of Silver Medals",
       title = "Relationship Between Number of Silver Medals and
       Gender Inequality Index in 2021") +
  geom_smooth(mapping = aes(x = Gender.Inequality.Index.Value,
                            y = Silver.Medal.Count,
                            color = HDI.label),
              se = FALSE,
              method = "gam",
              formula = y~x) +
  geom_smooth(mapping = aes(x = Gender.Inequality.Index.Value,
                            y = Silver.Medal.Count),
              se = FALSE,
              method = "gam",
              formula = y~x)

# Graph of Bronze Medal Count vs Gender Inequality
ggplot(data = gii[gii$Bronze.Medal.Count != 0,]) +
  geom_point(mapping = aes(x = Gender.Inequality.Index.Value,
                           y = Bronze.Medal.Count,
                           color = HDI.label)) +
  labs(x = "Gender Inequality Index",
       y = "Number of Bronze Medals",
       title = "Relationship Between Number of Bronze Medals and
       Gender Inequality Index in 2021") +
  geom_smooth(mapping = aes(x = Gender.Inequality.Index.Value,
                            y = Bronze.Medal.Count,
                            color = HDI.label),
              se = FALSE,
              method = "gam",
              formula = y~x) +
  geom_smooth(mapping = aes(x = Gender.Inequality.Index.Value,
                            y = Bronze.Medal.Count),
              se = FALSE,
              method = "gam",
              formula = y~x)

# Graph of Gold Medal Count vs Gender Participation
ggplot(data = gii) +
  geom_point(mapping = aes(x = GPI,
                           y = Gold.Medal.Count,
                           color = HDI.label)) +
  labs(x = "Women Participation In Olympics",
       y = "Number of Gold Medals",
       title = "Relationship Between Number of Gold Medals and
       Women Participation in Olympics in 2021") +
  geom_smooth(mapping = aes(x = GPI,
                            y = Gold.Medal.Count),
              se = FALSE,
              method = "gam",
              formula = y~x)

# Graph of Silver Medal Count vs Gender Participation
ggplot(data = gii) +
  geom_point(mapping = aes(x = GPI,
                           y = Silver.Medal.Count,
                           color = HDI.label)) +
  labs(x = "Women Participation In Olympics",
       y = "Number of Silver Medals",
       title = "Relationship Between Number of Silver Medals and
       Women Participation in Olympics in 2021") +
  geom_smooth(mapping = aes(x = GPI,
                            y = Silver.Medal.Count),
              se = FALSE,
              method = "gam",
              formula = y~x)

# Graph of Bronze Medal Count vs Gender Participation
ggplot(data = gii) +
  geom_point(mapping = aes(x = GPI,
                           y = Bronze.Medal.Count,
                           color = HDI.label)) +
  labs(x = "Women Participation In Olympics",
       y = "Number of Bronze Medals",
       title = "Relationship Between Number of Bronze Medals and
       Women Participation in Olympics in 2021") +
  geom_smooth(mapping = aes(x = GPI,
                            y = Bronze.Medal.Count),
              se = FALSE,
              method = "gam",
              formula = y~x)


gii$Total.Medals = rowSums(gii[, c("Gold.Medal.Count",
                                   "Silver.Medal.Count",
                                   "Bronze.Medal.Count")])

gii$GII.Quartile = cut(gii$Gender.Inequality.Index.Value,
                       breaks = c(0,
                                  0.25,
                                  0.5,
                                  0.75,
                                  1),
                       labels = c("Very High",
                                  "High",
                                  "Medium",
                                  "Low"))

gii$GII.Quartile = factor(gii$GII.Quartile,
                          levels = c("Very High",
                                     "High",
                                     "Medium",
                                     "Low"),
                          labels = c("Very High",
                                     "High",
                                     "Medium",
                                     "Low"))

sumQuartile = tapply(gii$Total.Medals, gii$GII.Quartile, sum)

df = data.frame(Quartile = names(sumQuartile), Sum = sumQuartile)

# Barplot of Medal Count vs Gender Equality Quartile
ggplot(df,
       mapping = aes(x = Quartile,
                     y = Sum,
                     fill = Quartile)) +
  geom_bar(stat = "identity") +
  labs(title = "Barplot of Medals by Quartile",
       x = "Gender Equality Quartiles", y = "Total Medals")

# Question 3

gdp = data.frame(read.csv("WDICountry.csv"))
names(gdp)[1] = "NOC"
gii = merge(gii, gdp, by = "NOC", all.x = TRUE)

gii$Income.Group = factor(gii$Income.Group,
                          levels = c("Low income",
                                     "Lower middle income",
                                     "Upper middle income",
                                     "High income"),
                          labels = c("Low",
                                     "Lower Middle",
                                     "Upper Middle",
                                     "High"))

avg = gii %>% group_by(Income.Group) %>% summarize(avg =  mean(GPI))

# Barplot of Gender Participation vs Income Group
ggplot(avg[!is.na(avg$Income.Group),],
       mapping = aes(x = Income.Group,
                     y = avg,
                     fill = Income.Group)) +
  geom_bar(stat = "identity") +
  labs(title = "Barplot of Women Participation by Income Group",
       x = "Income Group", y = "Women Participation")

avg = gii %>% group_by(Income.Group) %>% summarize(avg =  mean(Total.Medals))

# Barplot of Average Medal Count vs Income Group
ggplot(avg[!is.na(avg$Income.Group),],
       mapping = aes(x = Income.Group,
                     y = avg,
                     fill = Income.Group)) +
  geom_bar(stat = "identity") +
  labs(title = "Barplot of Average Medal Count for Women by Income Group",
       x = "Income Group", y = " Average Medal Count for Women")

avg = gii %>% group_by(Income.Group) %>% summarize(avg =  mean(Gold.Medal.Count))

# Barplot of Average Gold Medal Count vs Income Group
ggplot(avg[!is.na(avg$Income.Group),],
       mapping = aes(x = Income.Group,
                     y = avg,
                     fill = Income.Group)) +
  geom_bar(stat = "identity") +
  labs(title = "Barplot of Average Gold Medal Count for Women by Income Group",
       x = "Income Group", y = "Average Gold Medal Count for Women")

avg = gii %>% group_by(Income.Group) %>% summarize(avg =  mean(Silver.Medal.Count))

# Barplot of Average Silver Medal Count vs Income Group
ggplot(avg[!is.na(avg$Income.Group),],
       mapping = aes(x = Income.Group,
                     y = avg,
                     fill = Income.Group)) +
  geom_bar(stat = "identity") +
  labs(title = "Barplot of Average Silver Medal Count for Women by Income Group",
       x = "Income Group", y = "Average Silver Medal Count for Women")

avg = gii %>% group_by(Income.Group) %>% summarize(avg =  mean(Bronze.Medal.Count))

# Barplot of Average Bronze Medal Count vs Income Group
ggplot(avg[!is.na(avg$Income.Group),],
       mapping = aes(x = Income.Group,
                     y = avg,
                     fill = Income.Group)) +
  geom_bar(stat = "identity") +
  labs(title = "Barplot of Average Bronze Medal Count for Women by Income Group",
       x = "Income Group", y = "Average Bronze Medal Count for Women")

olympics = merge(olympics, gdp, by = "NOC", all.x = TRUE)

olympics$Income.Group = factor(olympics$Income.Group,
                               levels = c("Low income",
                                          "Lower middle income",
                                          "Upper middle income",
                                          "High income"),
                               labels = c("Low",
                                          "Lower Middle",
                                          "Upper Middle",
                                          "High"))

avg = olympics[olympics$Year == 2020,] %>% group_by(Income.Group) %>% summarize(avg = length(Name)/length(unique(NOC)))

# Barplot of Average Participation vs Income Group
ggplot(avg[!is.na(avg$Income.Group),],
       mapping = aes(x = Income.Group,
                     y = avg,
                     fill = Income.Group)) +
  geom_bar(stat = "identity") +
  labs(title = "Barplot of Average Participation in 2021 Olympics by Income Group",
       x = "Income Group", y = "Average Participation in 2021 Olympics")

avg = olympics[olympics$Year == 2020 & olympics$Medal != "",] %>% group_by(Income.Group) %>% summarize(avg = length(Name)/length(unique(NOC)))

# Barplot of Average Medal Count vs Income Group
ggplot(avg[!is.na(avg$Income.Group),],
       mapping = aes(x = Income.Group,
                     y = avg,
                     fill = Income.Group)) +
  geom_bar(stat = "identity") +
  labs(title = "Barplot of Average Medal Count in 2021 Olympics by Income Group",
       x = "Income Group", y = "Average Medal Count in 2021 Olympics")